using System;
using System.Collections.Generic;

namespace SovTechBackend.Service.DTOs
{
    public class PeopleDTO
    {

        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<PeopleModel> Results { get; set; }
    }
    public class PeopleModel
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public List<string> Films { get; set; }
        public List<string> Species { get; set; }
        public List<string> Vehicles { get; set; }
        public List<string> Starships { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }


    public class SwapiPeopleResult
    {
        public string count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<SwapiPeople> results { get; set; }
    }
    public class SwapiPeople
    {
        public string name { get; set; }
        public string height { get; set; }
        public string mass { get; set; }
        public string hair_color { get; set; }
        public string skin_color { get; set; }
        public string eye_color { get; set; }
        public string birth_year { get; set; }
        public string gender { get; set; }
        public String[] films { get; set; }
        public string[] species { get; set; }
        public string[] vehicles { get; set; }
        public string[] starships { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
        public string url { get; set; }
    }



}
