using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public class WorldEvent : Event, IHasTarget<Worlds.World>
    {
        public WorldEvent(API.Server server, Worlds.World world) : base(server)
        {
            World = world;
        }

        public Worlds.World World { get; }

        Worlds.World IHasTarget<Worlds.World>.Target => World;
    }
}
