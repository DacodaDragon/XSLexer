﻿using System.Collections.Generic;

namespace XSLexer.Data
{
    static class DataFileParser
    {
        private static readonly char[] WHITESPACE_CHARS = { ' ', '\t', (char)13};

        public static DataContainer[] Parse(string dataString)
        {
            string listName = "";
            List<DataValue> dataValues = new List<DataValue>();
            List<DataContainer> dataContainers = new List<DataContainer>();

            string[] lines = dataString.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (IsEmpty(line) || IsComment(line))
                    continue;

                if (IsListDefinition(line))
                {
                    if (listName != "")
                    {
                        dataContainers.Add(new DataContainer(listName, dataValues.ToArray()));
                    }

                    listName = ConvertToListName(line);
                    dataValues.Clear();
                    continue;
                }

                if (IsListEntry(line))
                {
                    dataValues.Add(ConvertToDataValue(line));
                }
            }

            if (listName != "")
            {
                dataContainers.Add(new DataContainer(listName, dataValues.ToArray()));
            }

            return dataContainers.ToArray();
        }

        private static bool IsEmpty(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        private static bool IsComment(string s)
        {
            return s.Trim(WHITESPACE_CHARS).StartsWith("#");
        }

        private static bool IsListDefinition(string s)
        {
            string trimmed = s.Trim(WHITESPACE_CHARS)
                .Replace(" ", "")
                .Replace("\t", "")
                .Replace("\n", "");

            return trimmed.EndsWith(">");
        }

        private static bool IsListEntry(string s)
        {
            string[] values = s.Trim(WHITESPACE_CHARS).Split(':');
            return values.Length == 2;
        }


        private static DataValue ConvertToDataValue(string s)
        {
            string[] values = s.Trim(WHITESPACE_CHARS).Split(':');
            return new DataValue(values[0].Trim(WHITESPACE_CHARS), values[1].Trim(WHITESPACE_CHARS));
        }

        private static string ConvertToListName(string s)
        {
            string name = s.Trim(WHITESPACE_CHARS)
                    .Replace(" ", "")
                    .Replace("\t", "")
                    .Replace("\n", "")
                    .Replace(">", "");

            return name;
        }
    }
}