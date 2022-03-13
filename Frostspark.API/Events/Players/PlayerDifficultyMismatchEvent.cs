using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    public class PlayerDifficultyMismatchEvent : PlayerEvent
    {
        public PlayerDifficultyMismatchEvent(Player player, API.Server server) : base(player, server)
        {

        }

        public DifficultyResult Result { get; set; } = DifficultyResult.Kick;

        public enum DifficultyResult
        {
            Kick,
            SwitchDifficulty,
            Allow
        }
    }
}
