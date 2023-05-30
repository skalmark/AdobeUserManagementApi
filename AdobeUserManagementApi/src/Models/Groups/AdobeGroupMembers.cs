using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models.Groups
{
    public class UpdateGroupMembers<T> : AdobeDoModel<T> where T : class
    {
        public string Usergroup { get; set; }
    }
}
