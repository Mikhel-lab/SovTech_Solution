using SovTechBackend.Model.DTOs;
using SovTechWeb.Service.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SovTechWeb.Service.Interface
{
    public interface ISOvTechService
    {
        Task<List<string>> GetJokeCategoriesAsync();
        Task<List<CategoryDetailResponse>> GetJokeCategoriesAsync(string jokeCategoryId);
        Task<BaseResponse<PeopleResponse>> GetStarWarsPeople(int pageNumber);
        Task<List<Searcing>> SearchByQuery(string query);
        Task<RootJokePeople> SearchQuery(string query);
        Task<CategoryDetailResponse> GetRandomJoke(string category);
        Task<List<PeopleResponse>> GetAllPeoples();



    }
}



