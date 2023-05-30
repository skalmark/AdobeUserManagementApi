﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models.Users
{
    internal class AdobeUserRequest<T> : AdobeDoModel<T> where T : class
    {
        [JsonPropertyName("user")]
        public string User { get; set; }
        [JsonPropertyName("requestID")]
        public string RequestID { get; set; }
    }
}
