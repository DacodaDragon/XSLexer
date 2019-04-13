using System.Text;

namespace XSLexer.Data
{
    /// <summary>
    /// Contains a single ID Value pair
    /// </summary>
    class DataValue
    {
        private readonly string m_ID;
        private readonly string m_Value;

        public string key => m_ID;
        public string value => m_Value;
        public bool isEmpty => string.IsNullOrWhiteSpace(m_ID) || string.IsNullOrWhiteSpace(m_Value);

        public DataValue(string id, string value)
        {
            m_ID = id;
            m_Value = Desanitize(value);
        }

        public override string ToString()
        {
            return $"\t{m_ID}:{m_Value}";
        }

        private string Desanitize(string value)
        {
            if (m_ID.Contains("Reg"))
                return value;

            StringBuilder buffer = new StringBuilder(value.Length);
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == '\\' && i+1 < value.Length)
                {
                    buffer.Append(Escape(value.Substring(i, 2)));
                    i++;
                }
                else
                {
                    buffer.Append(value[i]);
                }
            }
            return buffer.ToString();
        }

        private string Escape(string value)
        {
            switch (value)
            {
                case "\\n": return "\n";
                case "\\r": return "\r";
                case "\\f": return "\f";
                case "\\s": return "  ";
                case "\\t": return "\t";
                case "\\\"": return "\"";
                case "\\\'": return "\'";
                default: return value;
            }
        }
    }
}
