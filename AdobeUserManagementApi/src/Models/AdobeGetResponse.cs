using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models
{
    public class AdobeGetResponse<T> where T : class
    {
        [JsonProperty("lastPage")]
        public string LastPage { get; }
        [JsonProperty("result")]
        public string Result { get; }
        [JsonProperty("data")]
        public List<T> Data { get; }
    }

}
