using XSLexer.Data;

namespace XSLexer
{
    class StructureConfig
    {
        public DataSet StructureSet { get; }
        public DataSet Root { get; }

        public StructureConfig(DataSet structureSet)
        {
            StructureSet = structureSet;
            Root = structureSet.Filter(
                x => x.HasKey(StructureConsts.ROOT) &&
                x.GetValue(StructureConsts.ROOT).value == StructureConsts.BOOL_TRUE);
        }
    }
}
