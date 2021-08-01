using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Plugins.Exceptions
{
    public class IncompatibleGameVersionException : Exception
    {
        public IncompatibleGameVersionException(string message) : base(message) { }
    }
}
