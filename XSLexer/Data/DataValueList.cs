using System.Collections;

namespace XSLexer.Data
{
    class DataContainer : IEnumerable
    {
        private readonly string m_Name;
        private readonly DataValue[] m_DataValues;

        public string Name => m_Name;
        public int Length => m_DataValues.Length;

        public DataValue GetValue(int index)
        {
            return m_DataValues[index];
        }

        IEnumerator IEnumerable.GetEnumerator() { return m_DataValues.GetEnumerator(); }

        public DataContainer(string name, DataValue[] dataValues)
        {
            m_Name = name;
            m_DataValues = dataValues;
        }

        public DataValue this[int key]
        {
            get { return m_DataValues[key]; }
        }

    }
}
