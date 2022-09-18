using SovTechBackend.API.Iterfaces.Search;
using System.Collections.Generic;

namespace SovTechBackend.API.Model
{
    public class SwapiSearchRecord : ISearchRecord
    {
        public string ResultsApi { get; set; }
        public List<Person> Records { get; set; }
    }
}
