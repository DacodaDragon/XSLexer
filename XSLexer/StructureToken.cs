using XSLexer.Lexing;
using System.Collections.Generic;
using System.Text;

namespace XSLexer
{
    class StructureToken : Token
    {
        public string StructType { get; set; }
        public StructureToken Parent { get; set; }
        public List<StructureToken> Childs { get; } = new List<StructureToken>();

        public StructureToken(Token baseToken) : base(baseToken.Type, baseToken.Value, baseToken.LineNumber)
        {

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(StructType).Append(":").Append(Value).Append('\n');
            for (int i = 0; i < Childs.Count; i++)
            {
                stringBuilder.Append(Childs[i].ToString(2));
            }
            return stringBuilder.ToString();
        }

        private object ToString(int v)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(' ', v).Append(StructType).Append(":").Append(Value).Append('\n');
            for (int i = 0; i < Childs.Count; i++)
            {
                stringBuilder.Append(Childs[i].ToString(v+2));
            }
            return stringBuilder.ToString();
        }
    }
}
