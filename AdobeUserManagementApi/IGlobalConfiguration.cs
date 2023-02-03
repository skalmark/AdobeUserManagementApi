using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi
{
    public interface IGlobalConfiguration
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IGlobalConfiguration<out T> : IGlobalConfiguration
    {
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        T Entry { get; }
    }
}
