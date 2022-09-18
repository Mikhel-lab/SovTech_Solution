using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SovTechWeb.Service.Response
{
    public class CategoriesResponse
    {
        [JsonProperty("status")]
        public bool Status;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("errors")]
        public List<object> Errors;

        [JsonProperty("data")]
        public Data Data;
    }

    public class Data
    {
        [JsonProperty("categories")]
        public List<string> Categories;
    }

   
   

}

