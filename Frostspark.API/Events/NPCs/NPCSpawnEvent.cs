using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.NPCs
{
    public sealed class NPCSpawnEvent : NPCEvent, ICancellable
    {
        public NPCSpawnEvent(NPC npc, API.Server server) : base(npc, server)
        {
        }

        public bool Cancelled { get; set; }
    }
}
