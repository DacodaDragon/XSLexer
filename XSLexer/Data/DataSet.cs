using System.Collections.Generic;
using System.Text;

namespace XSLexer.Data
{
    class DataSet
    {
        private string m_Name;
        private DataContainer[] m_DataContainers;

        public string Name => m_Name;
        public int Length => m_DataContainers.Length;

        public DataSet Filter(System.Func<DataContainer, bool> Predicate)
        {
            List<DataContainer> filter = new List<DataContainer>();

            for (int i = 0; i < m_DataContainers.Length; i++)
            {
                if (Predicate.Invoke(m_DataContainers[i]))
                {
                    filter.Add(m_DataContainers[i]);
                }
            }
            return new DataSet(m_Name + " Filtered", filter.ToArray());
        }

        public DataSet FilterOut(System.Func<DataContainer, bool> Predicate)
        {
            List<DataContainer> filter = new List<DataContainer>();

            for (int i = 0; i < m_DataContainers.Length; i++)
            {
                if (!Predicate.Invoke(m_DataContainers[i]))
                {
                    filter.Add(m_DataContainers[i]);
                }
            }
            return new DataSet(m_Name + "Filtered", filter.ToArray());
        }

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

        public DataSet(string name, params DataContainer[] containers)
        {
            this.m_Name = name;
            this.m_DataContainers = containers;
        }

        public DataSet(string name)
        {
            this.m_Name = name;
            this.m_DataContainers = new DataContainer[0];
        }

        public DataContainer this[int i]
        {
            get { return GetSet(i); }
        }

        public DataContainer this[string i]
        {
            get { return GetSet(i); }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("DataSet: ").AppendLine(Name);
            for (int i = 0; i < Length; i++)
            {
                stringBuilder.Append(this[i].ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
