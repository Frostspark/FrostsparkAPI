using Frostspark.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.NPCs
{
    public sealed class NPCUpdateEvent : NPCEvent
    {
        public NPCUpdateEvent(NPC npc, API.Server server) : base(npc, server)
        {
        }
    }
}
