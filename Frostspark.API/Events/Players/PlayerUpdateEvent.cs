using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when the player has been updated by the server.
    /// </summary>
    public class PlayerUpdateEvent : PlayerEvent
    {
        public PlayerUpdateEvent(Player player, API.Server server) : base(player, server)
        {
        }
    }
}
