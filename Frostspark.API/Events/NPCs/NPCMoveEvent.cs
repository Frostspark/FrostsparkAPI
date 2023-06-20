using Frostspark.API.Entities;
using Frostspark.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.NPCs
{
    public sealed class NPCMoveEvent : NPCEvent
    {
        public NPCMoveEvent(Vector2D<float> from, Vector2D<float> to, NPC npc, API.Server server) : base(npc, server)
        {
            OldPosition = from;
            NewPosition = to;
        }

        /// <summary>
        /// Where this NPC moved from.
        /// </summary>
        public Vector2D<float> OldPosition { get; private set; }

        /// <summary>
        /// Where this NPC has moved to.
        /// </summary>
        public Vector2D<float> NewPosition { get; set; }

        public bool Cancelled { get; set; }
    }
}
