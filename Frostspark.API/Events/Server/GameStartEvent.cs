namespace Frostspark.API.Events.Server
{
    public class GameStartEvent : Event
    {
        public GameStartEvent(API.Server server) : base(server)
        {
        }
    }
}
