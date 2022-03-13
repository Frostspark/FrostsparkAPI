using System;

namespace Frostspark.API.Enums
{
    [Flags]
    public enum WireToolMode : byte
    {
        Red = 1,
        Green = 2,
        Blue = 4,
        Yellow = 8,
        Actuator = 16,
        Cutter = 32
    }
}
