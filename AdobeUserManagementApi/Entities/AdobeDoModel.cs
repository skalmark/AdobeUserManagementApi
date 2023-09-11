using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.Models
{
    public class AdobeDoModel<T> where T : class
    {
        [JsonPropertyName("do")]
        public List<T> Do { get; set; }
    }
}
