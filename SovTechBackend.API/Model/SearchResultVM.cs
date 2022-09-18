

using SovTechBackend.Model.DTOs;

namespace SovTechBackend.API.Model
{
    public class SearchResultVM
    {
        public SwapiPeople Peoples { get; set; }
        public JokeDTO Jokes { get; set; }
    }
}
