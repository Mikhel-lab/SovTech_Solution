using Newtonsoft.Json;
using System.Collections.Generic;

namespace SovTechWeb.Service.Response
{
    public class SearchDetailResponse
    {
        [JsonProperty("peoples")]
        public Peoples Peoples;

        [JsonProperty("jokes")]
        public Jokes Jokes;
    }

    public class Searcing
    {
        //public string[] categories { get; set; }
        //public string created_at { get; set; }
        //public string icon_url { get; set; }
        //public string id { get; set; }
        //public string updated_at { get; set; }
        //public string url { get; set; }
        //public string value { get; set; }

        public string api_name { get; set; }
        public Chuck chuck { get; set; }
        public People swapi { get; set; }

    }

    public class People
    {
        public List<result> results { get; set; }
        
    }
   
    public class result
    {
        public string name { get; set; }
        public string height { get; set; }
        public string mass { get; set; }
        public string hair_color { get; set; }
        public string skin_color { get; set; }
        public string eye_color { get; set; }
        public string birth_year { get; set; }
        public string gender { get; set; }
        public string homeworld { get; set; }
        public string[] films { get; set; }
        public string[] species { get; set; }
        public string[] vehicles { get; set; }
        public string[] starships { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
        public string url { get; set; }
    }

    public class Chuck
    {
        public List<json> result { get; set; }
    }
    public class json
    {
        public string[] categories { get; set; }
        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }

    public class Jokes
    {
        [JsonProperty("total")]
        public int Total;

        [JsonProperty("result")]
        public List<Result> Result;
    }

    public class Peoples
    {
        [JsonProperty("name")]
        public object Name;

        [JsonProperty("height")]
        public object Height;

        [JsonProperty("mass")]
        public object Mass;

        [JsonProperty("hair_color")]
        public object HairColor;

        [JsonProperty("skin_color")]
        public object SkinColor;

        [JsonProperty("eye_color")]
        public object EyeColor;

        [JsonProperty("birth_year")]
        public object BirthYear;

        [JsonProperty("gender")]
        public object Gender;

        [JsonProperty("films")]
        public object Films;

        [JsonProperty("species")]
        public object Species;

        [JsonProperty("vehicles")]
        public object Vehicles;

        [JsonProperty("starships")]
        public object Starships;

        [JsonProperty("created")]
        public object Created;

        [JsonProperty("edited")]
        public object Edited;

        [JsonProperty("url")]
        public object Url;
    }

    public class Result
    {
        [JsonProperty("categories")]
        public List<object> Categories;

        [JsonProperty("createdAt")]
        public object CreatedAt;

        [JsonProperty("iconUrl")]
        public object IconUrl;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("updatedAt")]
        public object UpdatedAt;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("value")]
        public string Value;
    }

    public class Root
    {
        [JsonProperty("peoples")]
        public Peoples Peoples;

        [JsonProperty("jokes")]
        public Jokes Jokes;
    }

}

