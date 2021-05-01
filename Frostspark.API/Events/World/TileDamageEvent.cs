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
    public class TileDamageEvent : TileEvent, ICancellable, IHasSource<Player>
    {
        public TileDamageEvent(Player player, byte damage, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Player = player;
            Damage = damage;
        }

        public Player Player { get; }

        /// <summary>
        /// The hitpoints the tile will be damaged for.
        /// </summary>
        public byte Damage { get; }

        public bool Cancelled { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
