using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player is considered fully in-game.
    /// </summary>
    public class PlayerJoinedEvent : PlayerEvent
    {
        public PlayerJoinedEvent(Player player, API.Server server) : base(player, server)
        {
        }
    }
}
