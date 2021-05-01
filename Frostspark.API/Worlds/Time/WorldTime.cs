namespace Frostspark.API.Worlds.Time
{
    public struct WorldTime
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
    }
}
