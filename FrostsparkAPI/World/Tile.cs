using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.World
{
    public abstract class Tile
    {
        /// <summary>
        /// This tile's position in the world
        /// </summary>
        public abstract Vector2D<int> Position { get; }

        /// <summary>
        /// The tile's foreground type
        /// </summary>
        public abstract ushort Type { get; set; }

        /// <summary>
        /// The tile's background type
        /// </summary>
        public abstract ushort Wall { get; set; }

        /// <summary>
        /// The tile's liquid level
        /// </summary>
        public abstract byte LiquidLevel { get; set; }

        /// <summary>
        /// The tile's liquid type
        /// </summary>
        public abstract TileLiquidType LiquidType { get; set; }

        /// <summary>
        /// The tile's texture frame
        /// </summary>
        public abstract Vector2D<short> Frame { get; set; }
    }
}
