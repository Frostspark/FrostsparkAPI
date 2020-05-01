using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player passes the version check and is about to get a slot assigned to them.
    /// </summary>
    public class PlayerAssignSlotEvent : Event
    {
        public PlayerAssignSlotEvent(API.Server server) : base(server)
        {
        }

        /// <summary>
        /// The <see cref="API.Entities.Player"/> that is being assigned a slot.
        /// <para>The player object, at this moment, may not support certain operations as it isn't guaranteed to be backed by a server entity</para>
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The slot that will be assigned to the player.
        /// <para>
        /// Be aware that assigning a slot through this setter may cause issues if the slot is already taken. Use <see cref="PlayerList.BySlot(int)"/> to check if the slot is free.
        /// </para>
        /// Setting this to null will cause the server to assign one on its own.
        /// </summary>
        public byte? Slot { get; set; }
    }
}
