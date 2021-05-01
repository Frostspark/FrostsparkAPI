using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Server
{
    public class ServerWatchdogEvent : Event, IAsynchronous
    {
        public ServerWatchdogEvent(API.Server server) : base(server)
        {
        }
    }
}
