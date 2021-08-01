using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public class WorldWireOperationEvent : WorldEvent, IHasSource<Player>, ICancellable
    {
        public WorldWireOperationEvent(Vector2D<int> start, Vector2D<int> end, WireToolMode mode, Player player, API.Server server, Worlds.World world) : base(server, world)
        {
            Start = start;
            End = end;
            Mode = mode;
            Source = player;
        }

        public Vector2D<int> Start { get; }

        public Vector2D<int> End { get; }

        public WireToolMode Mode { get; }

        public Player Source { get; }

        public bool Cancelled { get; set; }
    }
}
