namespace Frostspark.API.Events.Server
{
    public class ServerShutdownEvent : Event
    {
        public ServerShutdownEvent(API.Server server) : base(server)
        {
        }
    }
}
