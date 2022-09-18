using SovTechBackend.API.Iterfaces.Search;
using System.Collections.Generic;

namespace SovTechBackend.API.Model
{
    public class SearchResult
    {
        public List<ISearchRecord> Results { get; set; }
    }
}
