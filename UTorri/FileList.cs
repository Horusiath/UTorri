using System.Collections.Generic;
using Newtonsoft.Json;

namespace UTorri
{
    /// <summary>
    /// List of torrent files.
    /// </summary>
    public class FileList : RequestResult, ICollection<TorrentFile>
    {
        private readonly IList<TorrentFile> _files = new List<TorrentFile>();

        public FileList()
        {
        }

        public FileList(string json)
        {
            this.FromJson(json);
        }

        public void Add(TorrentFile item)
        {
            _files.Add(item);
        }

        public void Clear()
        {
            _files.Clear();
        }

        public bool Contains(TorrentFile item)
        {
            return _files.Contains(item);
        }

        public void CopyTo(TorrentFile[] array, int arrayIndex)
        {
            _files.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _files.Count; }
        }

        public bool IsReadOnly
        {
            get { return _files.IsReadOnly; }
        }

        public bool Remove(TorrentFile item)
        {
            return _files.Remove(item);
        }

        public IEnumerator<TorrentFile> GetEnumerator()
        {
            return _files.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _files.GetEnumerator();
        }

        public override void FromJson(string json)
        {
            var anon = JsonConvert.DeserializeAnonymousType(json, new
            {
                build = 0,
                files = new List<object>()
            });
            Build = anon.build;
            for (int i = 0; i < anon.files.Count; i+=2)
            {
                var info = new TorrentFile(anon.files[i].ToString());
                var data = anon.files[i + 1] as IEnumerable<object>;
                info.FillData(data);
            }
        }
    }
}
