using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

namespace Frostspark.API.Events.World
{
    public abstract class BlockBreakEvent : SingleTileEvent, ICancellable
    {
        public BlockBreakEvent(bool fail, bool drops, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Fail = fail;
            Drops = drops;
        }

        public bool Cancelled { get; set; }

        public bool Fail { get; set; }

        public bool Drops { get; set; }
    }
}
