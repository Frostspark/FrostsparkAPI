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
    public sealed class PlayerLiquidPourEvent : LiquidPourEvent, IHasSource<Player>
    {
        public PlayerLiquidPourEvent(Player source, BlockLiquidType type, byte level, Tile tile, Worlds.World world, API.Server server) : base(type, level, tile, world, server)
        {
            Source = source;
        }

        public Player Source { get; }
    }
}
