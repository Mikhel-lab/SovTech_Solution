using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SovTechWeb.Service.Response
{
    public class BaseResponse<T> where T : class
    {

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; } 

        [JsonPropertyName("errors")]
        public List<ErrorItemrResponse> Errors { get; set; }

        public BaseResponse()
        {
            Errors = new List<ErrorItemrResponse>();
        }

        public class ErrorItemrResponse
        {
            [JsonPropertyName("key")]
            public string Key { get; set; }

            [JsonPropertyName("errormessage")]
            public List<string> ErrorMessages { get; set; }
        }
    }
}
