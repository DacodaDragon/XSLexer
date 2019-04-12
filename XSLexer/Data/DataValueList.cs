using System.Text;

namespace XSLexer.Data
{
    class DataContainer
    {
        private readonly string m_Name;
        protected readonly DataValue[] m_DataValues;

        public string Name => m_Name;
        public int Length => m_DataValues.Length;
        public bool IsEmpty => m_DataValues == null || m_DataValues.Length == 0 || string.IsNullOrEmpty(m_Name);

        public DataValue GetValue(int index)
        {
            return m_DataValues[index];
        }

        public DataValue GetValue(string key)
        {
            return Resolve(key);
        }

        public bool HasKey(string key)
        {
            return !Resolve(key).isEmpty;
        }

        private DataValue Resolve(string key)
        {
            for (int i = 0; i < m_DataValues.Length; i++)
            {
                if (m_DataValues[i].key == key)
                {
                    return m_DataValues[i];
                }
            }
            return new DataValue("", "");
        }


        public DataContainer(string name, DataValue[] dataValues)
        {
            m_Name = name;
            m_DataValues = dataValues;
        }

        public DataValue this[int key]
        {
            get { return m_DataValues[key]; }
        }

        public DataValue this[string key]
        {
            get { return Resolve(key); }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("DataContainer: ").AppendLine(Name);
            for (int i = 0; i < Length; i++)
            {
                stringBuilder.AppendLine(this[i].ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
