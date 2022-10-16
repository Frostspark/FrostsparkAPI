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
    internal class PlayerLiquidDrainEvent : LiquidDrainEvent, IHasSource<Player>
    {
        public PlayerLiquidDrainEvent(Player source, byte new_level, Tile tile, Worlds.World world, API.Server server) : base(new_level, tile, world, server)
        {
            Source = source;
        }

        public Player Source { get; }
    }
}
