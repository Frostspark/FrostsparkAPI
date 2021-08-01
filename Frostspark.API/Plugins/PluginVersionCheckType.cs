using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Plugins
{
    public enum PluginVersionCheckType
    {
        /// <summary>
        /// This plugin requires this version precisely.
        /// </summary>
        Exact,

        /// <summary>
        /// This plugin requires at least this version.
        /// </summary>
        EqualOrGreater
    }
}
