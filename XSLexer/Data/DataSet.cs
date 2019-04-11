using System.Text;

namespace XSLexer.Data
{
    class DataSet
    {
        private string m_Name;
        private DataContainer[] m_DataContainers;

        public string Name => m_Name;
        public int Length => m_DataContainers.Length;

        public DataContainer GetSet(int i)
        {
            return m_DataContainers[i];
        }

        public DataContainer GetSet(string i)
        {
            return Resolve(i);
        }

        private DataContainer Resolve(string name)
        {
            for (int i = 0; i < m_DataContainers.Length; i++)
            {
                if (m_DataContainers[i].Name == name)
                    return m_DataContainers[i];
            }
            return new DataContainer("", null);
        }

        public DataSet(string name, DataContainer[] containers)
        {
            this.m_Name = name;
            this.m_DataContainers = containers;
        }

        public DataContainer this[int i]
        {
            get { return GetSet(i); }
        }

        public DataContainer this[string i]
        {
            get { return GetSet(i); }
        }
    }
}
