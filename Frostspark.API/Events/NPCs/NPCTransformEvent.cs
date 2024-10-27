using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.NPCs
{
    public sealed class NPCTransformEvent : NPCEvent, ICancellable
    {
        public NPCTransformEvent(int new_type, NPC npc, API.Server server) : base(npc, server)
        {
            NewType = new_type;
        }

        public int NewType { get; set; }

        public bool Cancelled { get; set; }
    }
}
