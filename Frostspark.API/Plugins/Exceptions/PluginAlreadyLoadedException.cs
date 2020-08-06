using System;

namespace Frostspark.API.Plugins.Exceptions
{
    [Serializable]
    public class PluginAlreadyLoadedException : Exception
    {
        public PluginAlreadyLoadedException(string message) : base(message)
        {
        }

        public PluginAlreadyLoadedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public PluginAlreadyLoadedException()
        {
        }

        protected PluginAlreadyLoadedException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
