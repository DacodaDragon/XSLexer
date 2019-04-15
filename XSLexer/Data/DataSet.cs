using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace XSLexer.Data
{
    class DataSet
    {
        private string m_Name;
        private DataContainer[] m_DataContainers;

        public string Name => m_Name;
        public int Length => m_DataContainers.Length;

        public void ForEach(System.Action<DataContainer> action)
        {
            for (int i = 0; i < m_DataContainers.Length; i++)
            {
                action.Invoke(m_DataContainers[i]);
            }
        }

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

        public DataSet Aggregate(DataSet set)
        {
            DataContainer[] containers = new DataContainer[m_DataContainers.Length + set.Length];

            for (long i = 0; i < m_DataContainers.Length; i++)
            {
                containers[i] = m_DataContainers[i];
            }

            long l = m_DataContainers.Length;
            for (long i = 0; i < m_DataContainers.Length; i++)
            {
                containers[l + i] = set[l + i];
            }

            return new DataSet("Aggregate", containers);
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

        public DataContainer GetSet(long i)
        {
            return m_DataContainers[i];
        }

        public DataContainer GetSet(string i)
        {
            return Resolve(i);
        }

        private DataContainer Resolve(string name)
        {
            for (long i = 0; i < m_DataContainers.LongLength; i++)
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

        public DataContainer this[long i]
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
