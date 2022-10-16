using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Items
{
    public abstract class DroppedItemUpdateEvent : DroppedItemEvent, ICancellable
    {
        public DroppedItemUpdateEvent(DroppedItem item, API.Server server) : base(item, server)
        {
        }

        public short Type { get; set; }

        public short Stack { get; set; }

        public byte Prefix { get; set; }

        public Vector2D<float> Position { get; set; }

        public Vector2D<float> Velocity { get; set; }

        public bool NoGrabDelay { get; set; }

        public bool Instanced { get; set; }

        public bool Shimmer { get; set; }

        public float ShimmerTimer { get; set; }

        public byte NPCLockoutTimer { get; set; }

        public bool Cancelled { get; set; }
    }
}
