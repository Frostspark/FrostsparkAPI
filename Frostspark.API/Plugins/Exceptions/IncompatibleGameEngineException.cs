using System;

namespace Frostspark.API.Plugins.Exceptions
{
    public class IncompatibleGameEngineException : Exception
    {
        public IncompatibleGameEngineException(string message) : base(message) { }
    }
}
