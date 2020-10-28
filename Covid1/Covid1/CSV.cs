using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid1
{
    class CSV
    {
        public const int CSV_SCHEMA_LINE_INDEX = 0;

        public List<CSVList> Data = new List<CSVList>();

        public CSV(string filePath)
        {
            string[] Lines = File.ReadAllLines(filePath);

            string[] Schema = GetCSVLineData(Lines[CSV_SCHEMA_LINE_INDEX]);

            foreach (string ElementName in Schema)
            {
                Data.Add(new CSVList(ElementName));
            }

            for (int Line = CSV_SCHEMA_LINE_INDEX + 1; Line < Lines.Length; Line++)
            {
                string[] LineData = GetCSVLineData(Lines[Line]);

                for (int DataIdx = 0; DataIdx < Data.Count; DataIdx++)
                {
                    Data[DataIdx].Values.Add(LineData[DataIdx]);
                }
            }
        }

        public CSVList GetListForName(string Name)
        {
            foreach (CSVList List in Data){
                if (List.Name == Name)
                {
                    return List;
                }
            }
            return null;
        }

        public static string[] GetCSVLineData(String line)
        {
            return line.Split(',');
        }
    }

    class CSVList
    {
        public string Name;

        public List<string> Values = new List<string>();

        public CSVList(string Name)
        {
            this.Name = Name;
        }

        public int GetSize()
        {
            return Values.Count;
        }

        public List<string> GetStrings()
        {
            return Values;
        }

        public List<double> GetDoubleFloats()
        {
            List<double> RetnList = new List<double>();
            foreach (string str in Values)
            {
                RetnList.Add(Double.Parse(str));
            }
            return RetnList;
        }        
    }
}
