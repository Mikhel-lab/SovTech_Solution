using SovTechBackend.API.Model;
using SovTechBackend.Service.categories;
using SovTechBackend.Service.People;
using SovTechBackend.Service.Joke;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using SovTechBackend.API.Iterfaces.Search;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;

namespace SovTechBackend.API.Controllers
{
    [ApiController]
    [Route("search")]
    public class SearchController : ControllerBase
    {
        private IPeopleService _peopleService;
        private IJokeService _jokService;

        private const string base_chuck_URL = "https://api.chucknorris.io";
        private const string base_swapi_URL = "https://swapi.dev";
        private string api_chuck = "/jokes/search?query={0}";
        private string api_swapi = "/api/people/?search={0}";
        public SearchController(IPeopleService peopleService, IJokeService jokeService)
        {
            _peopleService = peopleService;
            _jokService = jokeService;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string query)
        {
            SearchResultVM searchResultVM = new SearchResultVM();
            if (query == null)
            {
                return BadRequest();
            }
            else
            {
                var peoples = await _peopleService.SearchPeople(query);
                var jokes = await _jokService.SearchJokes(query);
                searchResultVM.Peoples = peoples;
                searchResultVM.Jokes = jokes;

                if (peoples == null && jokes == null)
                {
                    return NotFound();
                }
                return Ok(searchResultVM);
            }

        }


        [HttpGet("getsearch")]
        public async Task<List<Search>> GetSearch(string query)
        {
            dynamic content_chuck = string.Empty;
            dynamic content_swapi = string.Empty;
            var chuck = new Chuck();
            var people = new People();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(base_chuck_URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage chuck_response = await client.GetAsync(string.Format(api_chuck, query));
            if (chuck_response.IsSuccessStatusCode)
            {
                content_chuck = await chuck_response.Content.ReadAsStringAsync();
                chuck = JsonConvert.DeserializeObject<Chuck>(content_chuck);
            }
            else
            {
                content_chuck = string.Format("{0} ({1})", (int)chuck_response.StatusCode, chuck_response.ReasonPhrase);
            }

            HttpClient swapi_client = new HttpClient();
            swapi_client.BaseAddress = new Uri(base_swapi_URL);
            swapi_client.DefaultRequestHeaders.Accept.Clear();
            swapi_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage swapi_response = await swapi_client.GetAsync(string.Format(api_swapi, query));
            if (swapi_response.IsSuccessStatusCode)
            {
                content_swapi = await swapi_response.Content.ReadAsStringAsync();
                people = JsonConvert.DeserializeObject<People>(content_swapi);
            }
            else
            {
                content_swapi = string.Format("{0} ({1})", (int)swapi_response.StatusCode, swapi_response.ReasonPhrase);
            }

            List<Search> s = new List<Search>();
            s.Add(new Search
            {
                api_name = base_chuck_URL,
                chuck = chuck
            });
            s.Add(new Search
            {
                api_name = base_swapi_URL,
                swapi = people
            });

            return s;
        }


    }
}
