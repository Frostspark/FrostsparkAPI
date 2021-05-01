using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.NPCs
{
    public class NPCDamageByNPCEvent : NPCDamageEvent, IHasSource<NPC>
    {
        public NPCDamageByNPCEvent(NPC npc, NPC attacker, int damage, float knockback, HorizontalDirection direction, bool crit, API.Server server) : base(npc, damage, knockback, direction, crit, server)
        {
            Attacker = attacker;
        }

        NPC Attacker { get; }

        NPC IHasSource<NPC>.Source => Attacker;
    }
}
