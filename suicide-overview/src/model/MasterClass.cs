using suicide_overview.src.model.DecisionTreeClassifier;
using System.Collections.Generic;

namespace suicide_overview.src.model
{
    internal class MasterClass
    {
        private static readonly string[] p = { "Generation X", "Silent", "Millenials", "Boomers", "G.I.Generation" };
        public string[] GENERATIONS = p;
        private static readonly string[] p1 = { "Low risk", "Moderated risk", "High risk" };
        public string[] RISKLEVELS = p1;

        public Dictionary<string, List<Record>> countries;

        public Dictionary<string, Tree> treesByCountry;

        public MasterClass()
        {
            countries = new Dictionary<string, List<Record>>();
            treesByCountry = new Dictionary<string, Tree>();

            Loader.LoadData(countries);
        }

        //Retorna lista de strings con todos los paises
        public List<string> getAllCountries()
        {
            List<string> keysList = new List<string>();

            foreach (string item in countries.Keys)
            {
                keysList.Add(item);
            }

            return keysList;
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
            try
            {
                return countries[country];
            }
            catch (System.Exception)
            {
                throw new System.Exception("Error 404: Country not found");
            }
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

        //Cuenta de suicidios dada una generacion
        public int DeathsCountByGeneration(string generation)
        {
            int count = 0;

            foreach (Record item in RecordsByGeneration(generation))
            {
                count += item.Suicide_no;
            }

            return count;
        }

        //Cuenta de suicidios dada una generacion y un pais
        public int DeathsCountByGeneration(string generation, string country)
        {
            int count = 0;

            foreach (Record item in RecordsByGeneration(generation, country))
            {
                count += item.Suicide_no;
            }

            return count;
        }

        //Cuenta de suicidios dado un pais
        public int DeathsCountByCountry(string country)
        {
            int count = 0;

            foreach (Record item in RecordsByCountry(country))
            {
                count += item.Suicide_no;
            }

            return count;
        }

        //Cuenta de suicidios dado un pais y un año especifico.
        public int DeathsCountByCountry(string country, int year)
        {
            int count = 0;

            foreach (Record item in RecordsByCountry(country, year))
            {
                count += item.Suicide_no;
            }

            return count;
        }

        public Dictionary<string, double> simulateSuicideRisk_OwnImplementation(string countryName, int year, string generation, string sex)
        {
            Dictionary<string, double> risks;

            if (!treesByCountry.ContainsKey(countryName))
            {
                List<Record> records = RecordsByCountry(countryName);

                List<Dictionary<string, object>> setToTraining = new List<Dictionary<string, object>>();

                for (int i = 0; i < records.Count; i++)
                {
                    setToTraining.Add(records[i].getData());
                }

                Dictionary<string, int> variables = new Dictionary<string, int>();

                variables.Add("Year", 0);
                variables.Add("Sex", 1);
                variables.Add("Generation", 1);

                Tree myTree = new Tree(variables, "Risk");

                myTree.training(setToTraining);

                treesByCountry.Add(countryName, myTree);
            }

            risks = treesByCountry[countryName].Classifier(new Dictionary<string, object>() { { "Year", year }, { "Sex", sex }, { "Generation", generation } });

            return risks;
        }

        public Dictionary<string, double> simulateSuicideRisk_AccordImplementation(string countryName, int year, string generation, string sex)
        {


            return null;
        }
    }
}