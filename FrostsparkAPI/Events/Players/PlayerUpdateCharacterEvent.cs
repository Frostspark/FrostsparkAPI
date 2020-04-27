using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player updates their character's data.
    /// <para>This includes but is not limited to their name, hairstyle, hair/eye/clothing colors, UUID, gender, visible misc items...</para>
    /// For movement updates, see <seealso cref="PlayerUpdateMovementEvent"/>
    /// </summary>
    public class PlayerUpdateCharacterEvent : Event
    {
        public PlayerUpdateCharacterEvent(API.Server server) : base(server)
        {
        }

        public Player Player { get; }
    }
}
