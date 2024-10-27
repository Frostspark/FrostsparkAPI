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
        public NPCTransformedEvent(int old_type, NPC npc, API.Server server) : base(npc, server)
        {
            OldType = old_type;
        }

        public int OldType { get; set; }
    }
}
