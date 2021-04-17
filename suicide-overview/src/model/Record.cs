﻿namespace suicide_overview.src.model
{
    internal class Record
    {
        public string Year { get; set; }

        public string Sex { get; set; }

        public string AgeLower { get; set; }

        public string AgeUpper { get; set; }

        public int Suicide_no { get; set; }

        public int Population { get; set; }

        public double Ratio { get; set; }

        public string Generation { get; set; }

        public Record(string year, string sex, string ageLower, string ageUpper, int suicide_no, int population, double ratio, string generation)
        {
            Year = year;
            Sex = sex;
            AgeLower = ageLower;
            AgeUpper = ageUpper;
            Suicide_no = suicide_no;
            Population = population;
            Ratio = ratio;
            Generation = generation;
        }
    }
}