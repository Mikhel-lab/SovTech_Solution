using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SovTechWeb.Service.Response
{
    public class PeopleResponse
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("height")]
        public string Height;

        [JsonProperty("mass")]
        public string Mass;

        [JsonProperty("hairColor")]
        public object HairColor;

        [JsonProperty("skinColor")]
        public object SkinColor;

        [JsonProperty("eyeColor")]
        public object EyeColor;

        [JsonProperty("birthYear")]
        public object BirthYear;

        [JsonProperty("gender")]
        public string Gender;

        [JsonProperty("homeworld")]
        public string Homeworld;

        [JsonProperty("films")]
        public List<string> Films;

        [JsonProperty("species")]
        public List<string> Species;

        [JsonProperty("vehicles")]
        public List<string> Vehicles;

        [JsonProperty("starships")]
        public List<string> Starships;

        [JsonProperty("created")]
        public DateTime Created;

        [JsonProperty("edited")]
        public DateTime Edited;

        [JsonProperty("url")]
        public string Url;
    }



    public class PeopleResponseResult
    {
        [JsonProperty("count")]
        public int Count;

        [JsonProperty("next")]
        public string Next;

        [JsonProperty("previous")]
        public object Previous;

        [JsonProperty("results")]
        public List<PeopleResponse> Results;
    }

   

}
