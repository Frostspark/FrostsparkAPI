
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
    public sealed class PlayerBlockPlaceEvent : BlockPlaceEvent, IHasSource<Player>
    {
        public PlayerBlockPlaceEvent(Player player, int type, byte style, Tile tile, Worlds.World world, API.Server server) : base(type, style, tile, world, server)
        {
            Source = player;
        }

        public Player Source { get; }
    }
}
