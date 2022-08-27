using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class MultiblockTileEvent : TileEvent, IHasTarget<Tile[,]>
    {
        public MultiblockTileEvent(Rectangle area, Tile[,] tiles, Worlds.World world, API.Server server) : base(world, server)
        {
            Target = tiles;
            Area = area;
        }

        public Rectangle Area { get; }

        public Tile[,] Target { get; }
    }
}
