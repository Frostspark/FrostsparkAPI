namespace Frostspark.API.Events.Server
{
    /// <summary>
    /// Fired after the server & plugin logic for a frame occurs.
    /// </summary>
    public class ServerUpdateEvent : Event
    {
        public ServerUpdateEvent(API.Server server) : base(server)
        {
        }
    }
}
