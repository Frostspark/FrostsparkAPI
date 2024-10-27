using Frostspark.API.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.NPCs
{
    public sealed class NPCDeathEvent : NPCEvent
    {
        public NPCDeathEvent(NPC npc, API.Server server) : base(npc, server)
        {
        }
    }
}
