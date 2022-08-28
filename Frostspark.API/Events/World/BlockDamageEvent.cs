using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

namespace Frostspark.API.Events.World
{
    public abstract class BlockDamageEvent : SingleTileEvent, ICancellable
    {
        public BlockDamageEvent(byte damage, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Damage = damage;
        }

        /// <summary>
        /// The hitpoints the tile will be damaged for.
        /// </summary>
        public byte Damage { get; }

        public bool Cancelled { get; set; }
    }
}
