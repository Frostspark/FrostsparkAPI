using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players.Damage
{
    public class PlayerDamageByNPCEvent : PlayerDamageEvent, IHasSource<NPC>
    {
        public PlayerDamageByNPCEvent(Player player, NPC attacker, API.Server server, int damage, float knockback, HorizontalDirection direction, bool crit) : base(player, server, damage, knockback, direction, crit)
        {
            Attacker = attacker;
        }

        public NPC Attacker { get; }

        NPC IHasSource<NPC>.Source => Attacker;
    }
}
