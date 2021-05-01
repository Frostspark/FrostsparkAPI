using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.NPCs
{
    public abstract class NPCEvent : Event, IHasTarget<NPC>
    {
        protected NPCEvent(NPC npc, API.Server server) : base(server)
        {
            NPC = npc;
        }

        public NPC NPC { get; }

        NPC IHasTarget<NPC>.Target => NPC;
    }
}
