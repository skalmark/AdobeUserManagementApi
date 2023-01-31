using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models
{
    public class AdobeResponse
    {
        public int Completed { get; set; }
        public int NotCompleted { get; set; }
        public int CompletedInTestMode { get; set; }
        public string Result { get; set; }
        public List<AdobeError> Errors { get; set; }
    }
}
