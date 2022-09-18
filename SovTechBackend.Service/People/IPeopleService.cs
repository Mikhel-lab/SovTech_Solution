using SovTechBackend.Model.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SovTechBackend.Service.People
{
    public interface IPeopleService
    {
        Task<PeopleDTO> GetAllPeoples();
        Task<SwapiPeople> SearchPeople(string query);

        Task<List<SwapiPeople>> GetSwapiPeopleAsync();
    }
}
