using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.NPCs
{
    public class NPCDamageByPlayerEvent : NPCDamageEvent, IHasSource<Player>
    {
        public NPCDamageByPlayerEvent(NPC npc, Player attacker, int damage, float knockback, HorizontalDirection direction, bool crit, API.Server server) : base(npc, damage, knockback, direction, crit, server)
        {
            Attacker = attacker;
        }

        Player Attacker { get; }

        Player IHasSource<Player>.Source => Attacker;
    }
}
