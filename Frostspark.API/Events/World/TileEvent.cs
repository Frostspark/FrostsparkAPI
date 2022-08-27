using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

namespace Frostspark.API.Events.World
{
    public abstract class TileEvent : WorldEvent
    {
        protected TileEvent(Worlds.World world, API.Server server) : base(server, world)
        {

        }
    }
}
