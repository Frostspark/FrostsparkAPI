using Frostspark.API.Entities;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public class PlayerHitBlockEvent : PlayerEvent, ICancellable
    {
        public PlayerHitBlockEvent(Player player, Tile tile, byte damage, API.Server server) : base(player, server)
        {
            Tile = tile;
            Damage = damage;
        }

        /// <summary>
        /// The tile being damaged.
        /// </summary>
        public Tile Tile { get; }

        /// <summary>
        /// The hitpoints the tile will be damaged for.
        /// </summary>
        public byte Damage { get; }

        public bool Cancelled { get; set; }
    }
}
