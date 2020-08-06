using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player updates their movement variables (speed, position, and controls)
    /// <para>For visual player character updates, see <seealso cref="PlayerUpdateCharacterEvent"/></para>
    /// </summary>
    public class PlayerUpdateMovementEvent : PlayerEvent
    {
        public PlayerUpdateMovementEvent(API.Entities.Player player, API.Server server) : base(player, server)
        {

        }

        /// <summary>
        /// The new movement information for this player.
        /// </summary>
        public Player.MovementData Movement { get; }
    }
}
