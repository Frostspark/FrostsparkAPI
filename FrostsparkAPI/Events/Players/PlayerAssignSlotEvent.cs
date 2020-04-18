using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player passes the version check and gets a slot assigned to them.
    /// </summary>
    public class PlayerAssignSlotEvent : Event
    {
        public PlayerAssignSlotEvent(API.Server server) : base(server)
        {
        }

        /// <summary>
        /// The player
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The slot that will be assigned to player <see cref="Player"/>
        /// <para>
        /// Be aware that assigning a slot through this setter may cause issues if the slot is already taken. Use <see cref="PlayerList.BySlot(int)"/> to check if the slot is free.
        /// </para>
        /// </summary>
        public byte Slot { get; set; }
    }
}
