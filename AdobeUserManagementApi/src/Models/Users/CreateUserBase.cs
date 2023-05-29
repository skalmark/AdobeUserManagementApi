using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Responses.Users
{
    public class CreateUserBase
    {
        public string EmailAddress { get; set; }
        public string Country { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string option { get; } = "ignoreIfAlreadyExists";

    }
}
