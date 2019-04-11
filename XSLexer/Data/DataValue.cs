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
            m_Value = value;
        }
    }
}
