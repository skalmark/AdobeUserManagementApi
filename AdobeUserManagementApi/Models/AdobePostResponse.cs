using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.Models
{
    public class AdobePostResponse
    {
        public int Completed { get; }
        public int NotCompleted { get; }
        public int CompletedInTestMode { get; }
        public string Result { get; }
        public List<AdobeError> Errors { get; }
    }
}
