namespace Frostspark.API.Entities
{
    public abstract partial class Player
    {
        public struct ButtonInformation
        {
            public bool Up;
            public bool Down;
            public bool Left;
            public bool Right;
            public bool Jump;
            public bool UseItem;
        }
    }
}
