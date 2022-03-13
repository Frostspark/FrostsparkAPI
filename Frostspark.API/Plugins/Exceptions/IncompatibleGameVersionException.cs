using System;

namespace Frostspark.API.Plugins.Exceptions
{
    public class IncompatibleGameVersionException : Exception
    {
        public IncompatibleGameVersionException(string message) : base(message) { }
    }
}
