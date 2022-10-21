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
    public abstract class MultiblockEditEvent : MultiblockTileEvent, ICancellable
    {
        protected MultiblockEditEvent((short frameX, short frameY)[,] new_frame_values, Rectangle area, Tile[,] tiles, Worlds.World world, API.Server server) : base(area, tiles, world, server)
        {
            NewFrameValues = new_frame_values;
        }

        public (short frameX, short frameY)[,] NewFrameValues { get; set; }

        public bool Cancelled { get; set; }
    }
}
