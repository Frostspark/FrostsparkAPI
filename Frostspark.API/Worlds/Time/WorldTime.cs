using System;

namespace Frostspark.API.Worlds.Time
{
    public struct WorldTime : IEquatable<WorldTime>
    {
        public WorldTime(byte hour, byte minute, byte second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public WorldTime(byte hour, byte minute)
        {
            Hour = hour;
            Minute = minute;
            Second = 0;
        }

        public byte Hour;
        public byte Minute;
        public byte Second;

        public bool Equals(WorldTime other)
        {
            return Hour == other.Hour && Minute == other.Minute && Second == other.Second;
        }

        public override bool Equals(object obj)
        {
            return obj is WorldTime && Equals((WorldTime)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hour, Minute, Second);
        }

        public static bool operator ==(WorldTime left, WorldTime right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(WorldTime left, WorldTime right)
        {
            return !(left == right);
        }
    }
}
