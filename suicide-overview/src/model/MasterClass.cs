using System.Collections.Generic;

namespace suicide_overview.src.model
{
    internal class MasterClass
    {
        private Dictionary<string, List<Record>> countries;

        public MasterClass()
        {

            countries = new Dictionary<string, List<Record>>();

            Loader.LoadData(countries);

        }
    }
}