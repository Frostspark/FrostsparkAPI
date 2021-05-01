using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player is considered fully in-game.
    /// </summary>
    public class PlayerJoinEvent : PlayerEvent
    {
        public PlayerJoinEvent(Player player, API.Server server) : base(player, server)
        {
        }
    }
}
