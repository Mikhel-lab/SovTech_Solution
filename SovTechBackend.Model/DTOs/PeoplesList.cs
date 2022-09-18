using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SovTechBackend.Model.DTOs
{
    public class PeoplesList
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

    public class Jokes
    {
        [JsonProperty("total")]
        public int Total;

        [JsonProperty("result")]
        public List<Result> Result;
    }

    public class RootJokePeople
    {
        [JsonProperty("peoples")]
        public PeoplesList Peoples;

        [JsonProperty("jokes")]
        public Jokes Jokes;
    }
}
