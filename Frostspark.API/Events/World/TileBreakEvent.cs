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
    public class TileBreakEvent : TileEvent, IHasSource<Player>, ICancellable
    {
        public TileBreakEvent(Player player, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Player = player;
        }

        public Player Player { get; }

        public bool Cancelled { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
