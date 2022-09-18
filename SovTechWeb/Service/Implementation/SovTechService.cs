using Newtonsoft.Json;
using SovTechBackend.Model.DTOs;
using SovTechWeb.Service.Interface;
using SovTechWeb.Service.Response;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SovTechWeb.Service.Implementation
{
    public class SovTechService : ISOvTechService
    {
        private readonly IHttpClientFactory clientFactory;
        private readonly HttpClient httpClient;
        public SovTechService(IHttpClientFactory clientFactory, HttpClient httpClient) 
        {
            this.httpClient = clientFactory.CreateClient("GeneralService");
            this.clientFactory = clientFactory;
        }

        public async Task<List<PeopleResponse>> GetAllPeoples()
        {
            var resp = await httpClient.GetAsync("/allpeople");
            if (resp.IsSuccessStatusCode)
            {
                var respContent = await resp.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<PeopleResponse>>(respContent);
                return data;
            }

            return new List<PeopleResponse> { };
        }

        public async Task<List<string>> GetJokeCategoriesAsync()
        {
            var resp = await httpClient.GetAsync("chuck/categories");
            if (resp.IsSuccessStatusCode)
            {
                var respContent = await resp.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<string>>(respContent);
                return data;
            }

            return new List<string> { };
        }

        public async Task<List<CategoryDetailResponse>> GetJokeCategoriesAsync(string jokeCategoryId)
        {
            var url = $"api/Chuck/random/{jokeCategoryId}";
            var resp = await httpClient.GetAsync(url);
            if (resp.IsSuccessStatusCode)
            {
                var respContent = await resp.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<CategoryDetailResponse>>(respContent);
                return data;
            }
            else
            {
                return new List<CategoryDetailResponse>{ };
            }
        }

        public async Task<CategoryDetailResponse> GetRandomJoke(string category)
        {
            var url = $"jokes/random?category={category}";
            var resp = await httpClient.GetAsync(url);
            if (resp.IsSuccessStatusCode)
            {
                var respContent = await resp.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<CategoryDetailResponse>(respContent);
                return data;
            }
            else
            {
                return new CategoryDetailResponse { };
            }
        }

        public async Task<BaseResponse<PeopleResponse>> GetStarWarsPeople(int pageNumber)
        {
            var url = $"api/Swapi/people?pageNumber={pageNumber}";
            var resp = await httpClient.GetAsync(url);
            if (resp.IsSuccessStatusCode)
            {
                var respContent = await resp.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<BaseResponse<PeopleResponse>>(respContent);
                return data;
            }
            else
            {
                return new BaseResponse<PeopleResponse> { };
            }
        }

        public async Task<List<Searcing>> SearchByQuery(string query)
        {
            var url = $"/search/getsearch?query={query}";
            var resp = await httpClient.GetAsync(url);
            if (resp.IsSuccessStatusCode)
            {
                var respContent = await resp.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Searcing>>(respContent);
                return data;
            }
            else
            {
                return new List<Searcing> { };
            }
        }

        public async Task<RootJokePeople> SearchQuery(string query)
        {
            var url = $"/search?query={query}";
            var resp = await httpClient.GetAsync(url);
            if (resp.IsSuccessStatusCode)
            {
                var respContent = await resp.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<RootJokePeople>(respContent);
                return data;
            }
            else
            {
                return new RootJokePeople { };
            }
        }
    }
}
