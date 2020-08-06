using System;

namespace Frostspark.API.Plugins.Exceptions
{
    [Serializable]
    public class PluginNotFoundException : Exception
    {
        public PluginNotFoundException(string message) : base(message)
        {
        }

        public PluginNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public PluginNotFoundException()
        {
        }

        protected PluginNotFoundException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {

        }
    }
}
