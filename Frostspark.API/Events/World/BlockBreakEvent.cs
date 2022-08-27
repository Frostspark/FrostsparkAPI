using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

namespace Frostspark.API.Events.World
{
    public sealed class BlockBreakEvent : SingleTileEvent, IHasSource<Player>, ICancellable
    {
        public BlockBreakEvent(bool fail, bool drops, Player player, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Fail = fail;
            Drops = drops;
            Player = player;
        }

        public Player Player { get; }

        public bool Cancelled { get; set; }

        public bool Fail { get; set; }

        public bool Drops { get; set; }

        Player IHasSource<Player>.Source => Player;
    }
}
