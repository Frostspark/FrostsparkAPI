using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public sealed class WireBreakEvent : WireEvent, IHasSource<Player>, ICancellable
    {
        public WireBreakEvent(WireColor color, Player player, Tile tile, Worlds.World world, API.Server server) : base(color, tile, world, server)
        {
            Source = player;
        }

        public Player Source { get; }

        public bool Cancelled { get; set; }
    }
}
