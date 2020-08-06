using System;

namespace Frostspark.API.Plugins.Exceptions
{
    [Serializable]
    public class InvalidPluginException : Exception
    {
        public InvalidPluginException(string message) : base(message)
        {
        }

        public InvalidPluginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPluginException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {

        }

        public InvalidPluginException()
        {
        }
    }
}
