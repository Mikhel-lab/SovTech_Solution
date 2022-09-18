using SovTechBackend.API.Iterfaces.Search;
using System.Collections.Generic;

namespace SovTechBackend.API.Model
{
    public class ChuckSearchRecord : ISearchRecord
    {
        public string ResultsApi { get; set; }
        public List<RandomJoke> Records { get; set; }
    }
}
