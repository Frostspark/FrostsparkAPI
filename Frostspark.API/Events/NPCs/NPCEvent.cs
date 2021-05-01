using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
