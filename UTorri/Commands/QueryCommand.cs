using System.Collections.Generic;
using System.Text;

namespace UTorri.Commands
{
    /// <summary>
    /// Query command used to build query string for specyfic HttpConnection request.
    /// </summary>
    public abstract class QueryCommand
    {
        /// <summary>
        /// Type of command (Action or List).
        /// </summary>
        public CommandType Type { get; set; }

        /// <summary>
        /// Command text object representing specyfic type of operation.
        /// </summary>
        /// <example>QueryCommandText.GetFiles is equal to '?action=getfiles' request.</example>
        public string CommandText { get; set; }

        /// <summary>
        /// Query string key-value properties.
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> Parameters { get; set; }
        
        /// <summary>
        /// Allows to create custom command type.
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="type"></param>
        protected QueryCommand(string commandText, CommandType type)
        {
            CommandText = commandText;
            Type = type;
            Parameters = new Dictionary<string, string>();
        }

        /// <summary>
        /// Allows to create custom command type.
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="type"></param>
        protected QueryCommand(string commandText, CommandType type, params KeyValuePair<string , string >[] queries)
        {
            CommandText = commandText;
            Type = type;
            Parameters = queries;
        }

        /// <summary>
        /// Parse current QueryCommand to http query string.
        /// </summary>
        /// <returns>Http query string.</returns>
        public virtual string ToQuery()
        {
            var sb = new StringBuilder(CommandText);
            foreach (var pair in Parameters)
            {
                sb.Append('&').Append(pair.Key).Append('=').Append(pair.Value);
            }
            return sb.ToString();
        }
    }

    /// <summary>
    /// Query command type.
    /// </summary>
    public enum CommandType : byte
    {
        Action,
        List
    }
}
