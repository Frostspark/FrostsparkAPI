using System;

namespace Frostspark.API.Plugins.Exceptions
{
    public class IncompatibleAPIVersionException : Exception
    {
        public IncompatibleAPIVersionException(string message) : base(message) { }
    }
}
