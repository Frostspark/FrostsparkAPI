using Frostspark.API.Entities;
using Frostspark.API.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players.Damage
{
    public class PlayerDamageNPCEvent : PlayerDamageEvent
    {
        public PlayerDamageNPCEvent(Player player, API.Server server, API.Entities.NPC npc, int damage, float knockback, HorizontalDirection direction, bool critical) : base(player, server, damage, knockback, direction, critical)
        {
            NPC = npc;
        }

        public API.Entities.NPC NPC { get; }
    }
}
