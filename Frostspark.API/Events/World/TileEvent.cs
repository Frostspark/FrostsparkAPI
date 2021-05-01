using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

namespace Frostspark.API.Events.World
{
    public abstract class TileEvent : WorldEvent, IHasTarget<Tile>
    {
        protected TileEvent(Tile tile, Worlds.World world, API.Server server) : base(server, world)
        {
            Tile = tile;
        }

        public Tile Tile { get; }

        Tile IHasTarget<Tile>.Target => Tile;
    }
}
