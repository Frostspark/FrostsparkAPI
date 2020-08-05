using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player passes the version check and is about to get a slot assigned to them.
    /// </summary>
    public class PlayerAssignSlotEvent : PlayerEvent
    {
        public PlayerAssignSlotEvent(Player player, API.Server server) : base(player, server)
        {
        }

        /// <summary>
        /// The slot that will be assigned to the player.
        /// </summary>
        public byte Slot { get; }
    }
}
