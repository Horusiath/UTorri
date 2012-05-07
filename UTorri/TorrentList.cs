using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace UTorri
{
    /// <summary>
    /// Collection of Torrents.
    /// </summary>
    public class TorrentList : RequestResult, ICollection<Torrent>
    {
        protected internal IList<Torrent> torrents = new List<Torrent>();
        protected internal IList<string> removedTorrentsChecksums = new List<string>();

        /// <summary>
        /// Labels found in response object.
        /// </summary>
        public IDictionary<string,int> Labels { get; set; }

        /// <summary>
        /// Identifier of request associated with target list.
        /// </summary>
        public long BufferIdentity { get; set; }

        /// <summary>
        /// Creates new empty instance of TorrentList.
        /// </summary>
        public TorrentList()
        {
            torrents = new List<Torrent>();
            removedTorrentsChecksums = new List<string>();
            Labels = new Dictionary<string, int>();
        }

        /// <summary>
        /// Creates new instance of TorrentList with specified labels.
        /// </summary>
        /// <param name="labels"></param>
        public TorrentList(IEnumerable<KeyValuePair<string, int>> labels) : this()
        {
            Labels = new Dictionary<string, int>();
            foreach (var pair in labels)
            {
                Labels.Add(pair);
            }
        }

        /// <summary>
        /// Creates new instance of TorrentList filled with data from parsed JSON.
        /// </summary>
        /// <param name="json">Stringified JSON object.</param>
        public TorrentList(string json)
        {
            FromJson(json);
        }

        /// <summary>
        /// Merges two list (if they share a common BufferIdentity) into single actual TorrentList.
        /// </summary>
        /// <param name="other">List to merge.</param>
        /// <returns>New list - result of merging two list.</returns>
        /// <exception cref="MergeConfilcException">Thrown, when list have different BufferIdentity.</exception>
        public TorrentList Merge(TorrentList other)
        {
            if (other.BufferIdentity != this.BufferIdentity)
                throw new MergeConflictException("Merged torrent list have different buffer identities.");

            var result = new TorrentList(this.Labels);
            var toRemove = this.removedTorrentsChecksums.Union(other.removedTorrentsChecksums).Distinct();
            var toStay = this.torrents.Union(other.torrents).Distinct().ToList();
            foreach (var torrent in toStay.ToArray())
            {
                if (toRemove.Contains(torrent.Checksum))
                    toStay.Remove(torrent);
            }
            result.torrents = toStay;
            return result;
        }

        public void Add(Torrent item)
        {
            torrents.Add(item);
        }

        public void Clear()
        {
            torrents.Clear();
        }

        public bool Contains(Torrent item)
        {
            return torrents.Contains(item);
        }

        public void CopyTo(Torrent[] array, int arrayIndex)
        {
            torrents.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return torrents.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Torrent item)
        {
            return torrents.Remove(item);
        }

        public IEnumerator<Torrent> GetEnumerator()
        {
            return torrents
                .Where(x => !removedTorrentsChecksums.Contains(x.Checksum)).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return torrents
                .Where(x => !removedTorrentsChecksums.Contains(x.Checksum)).GetEnumerator();
        }

        /// <summary>
        /// Fills current list with data from parsed JSON.
        /// </summary>
        /// <param name="json">Stringified JSON object.</param>
        public override void FromJson(string json)
        {
            if (!json.Contains("torrentm"))
                FromNewJson(json);
            else
                FromContinuationJson(json);
        }

        /// <summary>
        /// Parses JSON object as new TorrentList result.
        /// </summary>
        /// <param name="json"></param>
        private void FromNewJson(string json)
        {
            var parsed = JsonConvert.DeserializeObject<TorrentListJson>(json);
            Build = parsed.build;
            if (parsed.label.Any())
                Labels = parsed.label.ToDictionary(x => x.First().ToString(),
                                                   x => int.Parse(x.Last().ToString()));
            BufferIdentity = long.Parse(parsed.torrentc);
            foreach (var torrent in parsed.torrents)
            {
                torrents.Add(new Torrent(torrent));
            }
        }

        /// <summary>
        /// Parses JSON object as continuation object of TorrentList downloaded earlier.
        /// </summary>
        /// <param name="json"></param>
        private void FromContinuationJson(string json)
        {
            var parsed = JsonConvert.DeserializeObject<TorrentListContinuationJson>(json);
            Build = parsed.build;
            BufferIdentity = long.Parse(parsed.torrentc);
            if (parsed.label.Any())
                Labels = parsed.label.ToDictionary(x => x.First().ToString(),
                                                   x => int.Parse(x.Last().ToString()));
            foreach (var torrent in parsed.torrentp)
            {
                torrents.Add(new Torrent(torrent));
            }
            foreach (var torrent in parsed.torrentm)
            {
                removedTorrentsChecksums.Add(torrent);
            }
        }

        #region Json parsable objects

        /// <summary>
        /// Helper class for parsing new JSON objects.
        /// </summary>
        internal class TorrentListJson
        {
            internal int build;

            internal ICollection<ICollection<object>> label;

            internal ICollection<ICollection<object>> torrents;

            internal string torrentc;
        }

        /// <summary>
        /// Helper class for parsing continuated JSON objects.
        /// </summary>
        internal class TorrentListContinuationJson
        {
            internal int build;

            internal ICollection<ICollection<object>> label;

            internal ICollection<ICollection<object>> torrentp;

            internal ICollection<string> torrentm;

            internal string torrentc;
        }

        #endregion
    }
}
