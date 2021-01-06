using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumControlCustomBrowser
{
    public class NameFromFileReader
    {
        public List<DataSetModel> GetNameFromFile()
        {
            List<DataSetModel> data = new List<DataSetModel>();

            var fileContentLines=  File.ReadAllLines("nomes.csv");
           
            foreach (var line in fileContentLines)
            {
                var columnsContent = line.Split(',');
                var dataLine = new DataSetModel();
                dataLine.alternative_names = columnsContent[0].Split('|');
                dataLine.classification = columnsContent[1];
                dataLine.first_name = columnsContent[2];

                if (!string.IsNullOrWhiteSpace(columnsContent[3]))
                    dataLine.frequency_female = Convert.ToInt32(columnsContent[3]);

                if (!string.IsNullOrWhiteSpace(columnsContent[4]))
                    dataLine.frequency_male = Convert.ToInt32((columnsContent[4]));

                dataLine.frequency_total = Convert.ToInt32(columnsContent[5]);
                dataLine.frequency_group = Convert.ToInt32(columnsContent[6]);
                dataLine.group_name = columnsContent[7];
                dataLine.ratio = Convert.ToDecimal(columnsContent[8]);
                data.Add(dataLine);
            }

            return data;
        }
    }

    public class DataSetModel
    {
        public string[] alternative_names { get; set; }
        public string classification { get; set; }
        public string first_name { get; set; }
        public int frequency_female { get; set; }
        public int frequency_male { get; set; }
        public int frequency_total { get; set; }
        public int frequency_group { get; set; }
        public string group_name { get; set; }
        public decimal ratio { get; set; }
        public char Sex
        {
            get
            {
                if (this.frequency_male > frequency_female)
                {
                    return 'M';
                }
                else
                {
                    return 'F';
                }
            }
        }
            
            
        public DataSetModel()
        {
            this.frequency_female = 0;
            this.frequency_male = 0;
            this.frequency_total = 0;
            this.frequency_group = 0;
        }

    }
}
