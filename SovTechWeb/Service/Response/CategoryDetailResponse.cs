using Newtonsoft.Json;
using System.Collections.Generic;

namespace SovTechWeb.Service.Response
{
    public class CategoryDetailResponse
    {
        [JsonProperty("categories")]
        public List<string> Categories;

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
}
