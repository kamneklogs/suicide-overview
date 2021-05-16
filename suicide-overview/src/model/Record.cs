using System.Collections.Generic;

namespace suicide_overview.src.model
{
    internal class Record
    {
        public int Year { get; set; }

        public string Sex { get; set; }

        public int AgeLower { get; set; }

        public int AgeUpper { get; set; }

        public int Suicide_no { get; set; }

        public int Population { get; set; }

        public double Ratio { get; set; }

        public string Generation { get; set; }

        public string Risk { get; set; }

        public bool ToAdd { get; set; }

        public Record(int year, string sex, int ageLower, int ageUpper, int suicide_no, int population, double ratio, string generation)
        {
            Year = year;
            Sex = sex;
            AgeLower = ageLower;
            AgeUpper = ageUpper;
            Suicide_no = suicide_no;
            Population = population;
            Ratio = ratio;
            Generation = generation;

            if (ratio < 20)
            {
                Risk = "Low risk";
            }
            else if (ratio < 40)
            {
                Risk = "Moderated risk";
            }
            else
            {
                Risk = "High risk ";
            }

            ToAdd = true;
        }

        public Dictionary<string, object> getData()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();

            data.Add("Year", Year);
            data.Add("Sex", Sex);
            data.Add("Generation", Generation);
            data.Add("Risk", Risk);

            return data;
        }
    }
}