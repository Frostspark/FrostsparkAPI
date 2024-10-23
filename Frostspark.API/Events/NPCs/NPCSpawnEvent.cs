using Frostspark.API.Entities;
using Frostspark.API.Entities.Sources;
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
        public NPCSpawnEvent(EntitySource spawn_source, NPC npc, API.Server server) : base(npc, server)
        {
            SpawnSource = spawn_source;
        }

        public EntitySource SpawnSource { get; private set; }

        public bool Cancelled { get; set; }
    }
}
