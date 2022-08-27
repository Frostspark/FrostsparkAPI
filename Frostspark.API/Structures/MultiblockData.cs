using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Structures
{
    public sealed class MultiblockData
    {
        public MultiblockData()
        {

        }

        public Rectangle Hitbox;

        public Tile[,] Tiles;
    }
}
