
using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World.Players
{
    public sealed class PlayerBlockBreakEvent : BlockBreakEvent, IHasSource<Player>
    {
        public PlayerBlockBreakEvent(Player player, bool fail, bool drops, Tile tile, Worlds.World world, API.Server server) : base(fail, drops, tile, world, server)
        {
            Source = player;
        }

        public Player Source { get; }
    }
}
