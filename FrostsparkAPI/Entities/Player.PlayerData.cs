using Frostspark.API.Utilities;

namespace Frostspark.API.Entities
{
    public abstract partial class Player
    {
        public class PlayerData
        {
            public byte SkinVariant;
            public byte HairType;
            public string Name;
            public byte HairDye;
            public byte HideVisuals;
            public byte HideVisuals2;
            public byte HideMisc;
            public Color HairColor;
            public Color SkinColor;
            public Color EyeColor;
            public Color ShirtColor;
            public Color UndershirtColor;
            public Color PantsColor;
            public Color ShoeColor;
            public byte Difficulty;
        }
    }
}
