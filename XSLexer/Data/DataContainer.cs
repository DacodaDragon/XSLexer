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
            if (Resolve(key, out DataValue dataValue))
            {
                return dataValue;
            }
            throw new System.Exception($"Key \"{key}\" not found in DataContainer \"{Name}\"");
        }

        public bool HasKey(string key)
        {
            return Resolve(key, out DataValue value);
        }

        private bool Resolve(string key, out DataValue value)
        {
            value = null;
            for (int i = 0; i < m_DataValues.Length; i++)
            {
                if (m_DataValues[i].key == key)
                {
                    value = m_DataValues[i];
                    return true;
                }
            }
            return false;
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
            get
            {
                return GetValue(key);
            }
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
