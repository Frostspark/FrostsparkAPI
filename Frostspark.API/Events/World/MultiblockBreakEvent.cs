using Frostspark.API.Entities;
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
    public abstract class MultiblockBreakEvent : MultiblockTileEvent, ICancellable
    {
        public MultiblockBreakEvent(bool fail, bool drops, Rectangle area, Tile[,] tiles, Worlds.World world, API.Server server) : base(area, tiles, world, server)
        {
            Fail = fail;
            Drops = drops;
        }

        public bool Cancelled { get; set; }

        public bool Fail { get; set; }

        public bool Drops { get; set; }
    }
}
