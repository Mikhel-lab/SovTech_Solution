using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using SovTechBackend.Model.DTOs;
using System.Linq;

namespace SovTechBackend.Service.People
{
    public class PeopleService : IPeopleService
    {
        public const string SWAPI_PEOPLE_URL = "https://swapi.dev/api/people";
        public PeopleService(){}

        public async Task<PeopleDTO> GetAllPeoples()
        {
            string Baseurl = "https://swapi.dev/api/";
            PeopleDTO people = new PeopleDTO();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();                
                //Sending request to find web api REST service resource Category List using HttpClient               
                HttpResponseMessage Res = await client.GetAsync("people");
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var responseData = Res.Content.ReadAsStringAsync().Result;
                    people = JsonConvert.DeserializeObject<PeopleDTO>(responseData, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                }
            }
            return people;
        }

        public async Task<List<SwapiPeople>> GetSwapiPeopleAsync()
        {
            List<SwapiPeople> swapiPeople = new List<SwapiPeople>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(SWAPI_PEOPLE_URL))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var res = JsonConvert.DeserializeObject<SwapiPeopleResult>(apiResponse);
                    swapiPeople = res.results;
                    while (res.next != null)
                    {
                        using (var responseNext = await httpClient.GetAsync(res.next))
                        {
                            apiResponse = await responseNext.Content.ReadAsStringAsync();
                            res = JsonConvert.DeserializeObject<SwapiPeopleResult>(apiResponse);
                            swapiPeople = swapiPeople.Concat(res.results).ToList();
                        }
                    }
                }
            }

            return swapiPeople;
        }

        public async Task<SwapiPeople> SearchPeople(string query)
        {
            string Baseurl = "https://swapi.dev/api/";
            SwapiPeople people = new SwapiPeople();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Sending request to find web api REST service resource Category List using HttpClient               
                HttpResponseMessage Res = await client.GetAsync("people/?search=" +query);
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var responseData = Res.Content.ReadAsStringAsync().Result;
                    people = JsonConvert.DeserializeObject<SwapiPeople>(responseData, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                }
            }
            return people;
        }
    }
}
