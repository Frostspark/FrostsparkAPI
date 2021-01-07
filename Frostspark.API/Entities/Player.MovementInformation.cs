namespace Frostspark.API.Entities
{
    public abstract partial class Player
    {
        public struct MovementInformation
        {
            /// <summary>
            /// Whether or not the player is attached to a rope via a pulley.
            /// </summary>
            public bool Pulley;

            /// <summary>
            /// The side of the rope the pulley is on.
            /// </summary>
            public byte PulleyDirection;

            /// <summary>
            /// Whether or not the player is moving.
            /// </summary>
            public bool Moving;

            /// <summary>
            /// Whether or not this player is currently in stealth.
            /// </summary>
            public bool Stealthed;

            /// <summary>
            /// What direction the gravity is set for this player
            /// <para>true = normal, false = inverse</para>
            /// </summary>
            public bool GravityDirection;

            /// <summary>
            /// Whether or not the player is raising their shield.
            /// </summary>
            public bool ShieldRaised;
        }
    }
}
