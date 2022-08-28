
using Frostspark.API.Entities;
using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World.Players
{
    public sealed class PlayerWirePlaceEvent : WirePlaceEvent, IHasSource<Player>
    {
        public PlayerWirePlaceEvent(Player player, WireColor color, Tile tile, Worlds.World world, API.Server server) : base(color, tile, world, server)
        {
            Source = player;
        }

        public Player Source { get; }
    }
}
