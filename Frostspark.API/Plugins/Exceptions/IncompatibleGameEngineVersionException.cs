using System;

namespace Frostspark.API.Plugins.Exceptions
{
    public class IncompatibleGameEngineVersionException : Exception
    {
        public IncompatibleGameEngineVersionException(string message) : base(message) { }
    }
}
