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
        public List<Record> RecordsByCountry(string countryName)
        {
            return countries[countryName];
        }

        //Retorna lista de todos los registros de muerte en un pais y año dados
        public List<Record> RecordsByCountry(string countryName, int year)
        {
            List<Record> result = countries[countryName];

            foreach (Record item in result)
            {
                if (item.Year != year)
                {
                    result.Remove(item);
                }
            }

            return result;
        }


        public List<Record> RecordsByGeneration(string generation)
        {
            List<Record> result = new List<Record>();


            foreach (Record item in AllRecords())
            {

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
    }
}