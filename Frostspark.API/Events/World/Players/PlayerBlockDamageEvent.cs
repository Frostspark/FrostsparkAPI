
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
    public sealed class PlayerBlockDamageEvent : BlockDamageEvent, IHasSource<Player>
    {
        public PlayerBlockDamageEvent(Player player, byte damage, Tile tile, Worlds.World world, API.Server server) : base(damage, tile, world, server)
        {
            Source = player;
        }

        public Player Source { get; }
    }
}
