using Newtonsoft.Json;
using System.Collections.Generic;

namespace SovTechWeb.Service.Response
{
    public class SearchCategoryResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("result")]
        public List<CategoryDetailResponse> CategoryDetails { get; set; }

        public SearchCategoryResponse()
        {
            CategoryDetails = new List<CategoryDetailResponse>();
        }
    }
}
