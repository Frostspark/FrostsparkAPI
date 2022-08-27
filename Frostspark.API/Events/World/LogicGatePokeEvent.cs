using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public sealed class LogicGatePokeEvent : SingleTileEvent, IHasSource<Player>, ICancellable
    {
        public LogicGatePokeEvent(Player source, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Source = source;
        }

        public bool Cancelled { get; set; }

        public Player Source { get; }
    }
}
