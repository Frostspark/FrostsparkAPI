using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player's character data is updated.
    /// <para>This includes but is not limited to their name, hairstyle, hair/eye/clothing colors, gender, visible misc items...</para>
    /// For movement updates, see <seealso cref="PlayerUpdateMovementEvent"/>
    /// </summary>
    public class PlayerUpdateCharacterEvent : Event
    {
        public PlayerUpdateCharacterEvent(API.Server server) : base(server)
        {

        }

        /// <summary>
        /// The player whose data is being updated.
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// The new character data.
        /// </summary>
        public Player.PlayerData NewData { get; }

        /// <summary>
        /// Whether or not the data will be force-updated.
        /// <para>If this is true, then the data will be forcibly re-sent to the client, rather than silently updated for everyone else.</para>
        /// </summary>
        public bool ForceUpdate { get; set; }
    }
}
