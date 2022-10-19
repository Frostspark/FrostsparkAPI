using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class WallPaintEvent : SingleTileEvent, ICancellable
    {
        protected WallPaintEvent(BlockPaint paint, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Paint = paint;
        }

        public BlockPaint Paint { get; set; }

        public bool Cancelled { get; set; }
    }
}
