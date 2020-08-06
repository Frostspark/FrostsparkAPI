using Frostspark.API.Utilities;

namespace Frostspark.API.Entities
{
    public abstract partial class Player
    {
        public partial class MovementData
        {
            /// <summary>
            /// What keys this player has pressed.
            /// </summary>
            public ButtonInformation Buttons;

            /// <summary>
            /// Which direction this player is facing.
            /// </summary>
            public bool Direction;

            /// <summary>
            /// Information about the player's movement.
            /// </summary>
            public MovementInformation Movement;

            /// <summary>
            /// The currently selected inventory slot.
            /// </summary>
            public byte SelectedSlot;

            /// <summary>
            /// The player's position on the map.
            /// </summary>
            public Vector2D<float> Position;

            /// <summary>
            /// The player's velocity (movement speed & direction) vector.
            /// </summary>
            public Vector2D<float> Velocity;
        }
    }
}
