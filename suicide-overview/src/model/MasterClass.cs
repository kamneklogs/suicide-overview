using System.Collections.Generic;
using System.Windows.Forms;

namespace suicide_overview.src.model
{
    internal class MasterClass
    {
        private Dictionary<string, List<Record>> countries;

        public MasterClass()
        {
            countries = new Dictionary<string, List<Record>>();

            Loader.LoadData(countries);

            MessageBox.Show("Sin errores");
        }

        //retorna todos los registros de suicidio sin clasificación por pais
        public List<Record> AllRecords()
        {
            List<Record> records = new List<Record>();

            foreach (List<Record> item in countries.Values)
            {
                foreach (Record record in item)
                {
                    records.Add(record);
                }
            }

            return records;
        }

        //Retorna lista de todos los registros de suicidio en un pais dado
        public List<Record> RecordsByCountry(string country)
        {
            return countries[country];
        }

        //Retorna lista de todos los registros de muerte en un pais y año dados
        public List<Record> RecordsByCountry(string country, int year)
        {
            List<Record> result = new List<Record>();

            foreach (Record item in countries[country])
            {
                if (item.Year == year)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        private IEnumerable<Record> RecordsByCountry(string country, int year, string sex)
        {
            List<Record> result = new List<Record>();

            foreach (Record item in countries[country])
            {
                if ((item.Year == year) && (item.Sex.Equals(sex)))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        //Retorna lista de todos los registros de suicidio en una generacion dada
        public List<Record> RecordsByGeneration(string generation)
        {
            List<Record> result = new List<Record>();

            foreach (Record item in AllRecords())
            {
                if (item.Generation.Equals(generation))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        //Retorna lista de todos los registros de suicidio en una generacion y pais dado
        public List<Record> RecordsByGeneration(string generation, string country)
        {
            List<Record> result = new List<Record>();

            foreach (Record item in RecordsByCountry(country))
            {
                if (item.Generation.Equals(generation))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        //Retorna lista de todos los registros de suicidio en una generacion, pais y año dada
        public List<Record> RecordsByGeneration(string generation, string country, int year)
        {
            List<Record> result = new List<Record>();

            foreach (Record item in RecordsByCountry(country, year))
            {
                if (item.Generation.Equals(generation))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        //Retorna lista de todos los registros de suicidio en una generacion, pais, año y genero dada
        public List<Record> RecordsByGeneration(string generation, string country, int year, string sex)
        {
            List<Record> result = new List<Record>();

            foreach (Record item in RecordsByCountry(country, year, sex))
            {
                if (item.Generation.Equals(generation))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        //***************************
        //CUENTAS
        //***************************

        //Retorna el numero de suicidios a nivel mundial por genero, se le pasa "male" o "female"
        public int DeathsCountByGender(string gender)
        {
            int count = 0;

            foreach (Record item in AllRecords())
            {
                if (item.Sex.Equals(gender))
                {
                    count += item.Suicide_no;
                }
            }

            return count;
        }

        //retorna suicidios totales dado un genero y un pais especifico
        public int DeathsCountByGender(string gender, string country)
        {
            int count = 0;

            foreach (Record item in RecordsByCountry(country))
            {
                if (item.Sex.Equals(gender))
                {
                    count += item.Suicide_no;
                }
            }

            return count;
        }

        //cuenta de muertes por genero, pais y año dado
        public int DeathsCountByGender(string gender, string country, int year)
        {
            int count = 0;

            foreach (Record item in RecordsByCountry(country, year))
            {
                if (item.Sex.Equals(gender))
                {
                    count += item.Suicide_no;
                }
            }

            return count;
        }

        //cuenta de suicidios dada un genero, pais, año y generación dada
        public int DeathsCountByGender(string gender, string country, int year, string generation)
        {
            int count = 0;

            foreach (Record item in RecordsByCountry(country, year))
            {
                if (item.Sex.Equals(gender) && item.Generation.Equals(generation))
                {
                    count += item.Suicide_no;
                }
            }

            return count;
        }

        //Cuenta de
        public int DeathsCountByGeneration(string generation)
        {
            int count = RecordsByGeneration(generation).Count;

            return count;
        }
    }
}