using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SovTechBackend.API.Model
{
    public class Person
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
        public List<string> films { get; set; }
        public List<string> species { get; set; }
        public List<string> vehicles { get; set; }
        public List<string> starships { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }

    }

    public class Search
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

    public interface ISearchRecordCollection
    {
        public Task<List<Search>> Searching(string query);
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
}
