﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models.Groups
{
    public class AddMembersModel
    {
        [JsonPropertyName("add")]
        public AddMembers AddMembers { get; set; }
    }
        
    public class AddMembers
    {
        [JsonPropertyName("user")]
        public List<string> Members { get; set; }
    }
}
