using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player's character data is updated.
    /// <para>This includes but is not limited to their name, hairstyle, hair/eye/clothing colors, gender, visible misc items...</para>
    /// For movement updates, see <seealso cref="PlayerUpdateMovementEvent"/>
    /// </summary>
    public class PlayerUpdateCharacterEvent : PlayerEvent, IClientsided
    {
        public PlayerUpdateCharacterEvent(Player player, API.Server server) : base(player, server)
        {
        }

        /// <summary>
        /// The new character data.
        /// </summary>
        public Player.PlayerData NewData { get; }

        public bool Modified { get; set; }
    }
}
