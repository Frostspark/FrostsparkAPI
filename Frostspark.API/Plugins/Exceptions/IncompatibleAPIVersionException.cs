using System;

namespace Frostspark.API.Plugins.Exceptions
{
    [Serializable]
    public class IncompatibleAPIVersionException : Exception
    {
        public IncompatibleAPIVersionException(string message) : base(message)
        {
        }

        public IncompatibleAPIVersionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public IncompatibleAPIVersionException()
        {
        }

        protected IncompatibleAPIVersionException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
            
        }
    }
}
