using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Plugins.Exceptions
{
    public class IncompatibleGameEngineVersionException : Exception
    {
        public IncompatibleGameEngineVersionException(string message) : base(message) { }
    }
}
