using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.NPC
{
    public abstract class NPCEvent : Event
    {
        protected NPCEvent(API.Entities.NPC npc, API.Server server) : base(server)
        {
            NPC = npc;
        }

        public API.Entities.NPC NPC { get; }
    }
}
