using Frostspark.API.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.NPCs
{
    public sealed class NPCTransformedEvent : NPCEvent
    {
        public NPCTransformedEvent(int new_type, NPC npc, API.Server server) : base(npc, server)
        {
            NewType = new_type;
        }

        public int NewType { get; set; }
    }
}
