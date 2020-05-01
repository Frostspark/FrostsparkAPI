namespace Frostspark.API.Entities
{
    public abstract partial class Player
    {
        public partial class MovementData
        {
            public class ButtonInformation
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
}
