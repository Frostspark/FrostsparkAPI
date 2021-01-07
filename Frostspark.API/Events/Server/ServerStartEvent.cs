namespace Frostspark.API.Events.Server
{
    public class ServerStartEvent : Event
    {
        public ServerStartEvent(API.Server server) : base(server)
        {
        }
    }
}
