using Frostspark.API.Classes;

namespace Frostspark.API.Events
{
    /// <summary>
    /// Fired when a player passes the version check and gets a slot assigned to them.
    /// </summary>
    public class PlayerAssignSlotEvent : Event
    {
        /// <summary>
        /// The player
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The slot that will be assigned to player <see cref="PlayerAssignSlotEvent.Player"/>
        /// <para>
        /// Be aware that assigning a slot through this setter may cause issues if the slot is already taken. Use <see cref="PlayerList.BySlot(int)"/> to check if the slot is free.
        /// </para>
        /// </summary>
        public byte Slot { get; set; }
    }
}
