using Frostspark.API.Enums;

namespace Frostspark.API.Events.Interfaces
{
    /// <summary>
    /// Represents a barebones implementation of a damage event.
    /// <para>This is used to directly influence prototypes of events like <see cref="NPCs.NPCDamageEvent"/> and <see cref="Players.Damage.PlayerDamageEvent"/></para>
    /// </summary>
    public interface IDamageEvent : IEventHandlerCompatible
    {
        /// <summary>
        /// The damage dealt.
        /// </summary>
        int Damage { get; set; }

        /// <summary>
        /// The strength of knockback inflicted.
        /// </summary>
        float Knockback { get; set; }

        /// <summary>
        /// The direction in which the knockback is directed
        /// </summary>
        HorizontalDirection Direction { get; set; }

        /// <summary>
        /// Whether or not this is a critical hit.
        /// </summary>
        bool Critical { get; set; }
    }
}
