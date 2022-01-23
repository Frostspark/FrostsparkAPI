using Frostspark.API.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    internal class PlayerDifficultyMismatchEvent : PlayerEvent
    {
        public PlayerDifficultyMismatchEvent(Player player, API.Server server) : base(player, server)
        {
        }

        public DifficultyResult Result { get; set; }

        public enum DifficultyResult
        {
            Kick,
            SwitchDifficulty,
            Allow
        }
    }
}
