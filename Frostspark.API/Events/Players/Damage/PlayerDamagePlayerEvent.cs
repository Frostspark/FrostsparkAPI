using Frostspark.API.Entities;
using Frostspark.API.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players.Damage
{
    public class PlayerDamagePlayerEvent : PlayerDamageEvent
    {
        public PlayerDamagePlayerEvent(Player player, API.Server server, Player victim, int damage, float knockback, HorizontalDirection direction, bool critical, bool pvp) : base(player, server, damage, knockback, direction, critical)
        {
            Victim = victim;
            PvP = pvp;
        }

        public Player Victim { get; }

        public bool PvP { get; set; }
    }
}
