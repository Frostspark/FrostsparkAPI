using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Entities
{
    public abstract class TileEntity
    {
        /// <summary>
        /// This <see cref="TileEntity"/>'s native index.
        /// </summary>
        public abstract int Index { get; }

        /// <summary>
        /// This <see cref="TileEntity"/>'s position in the world.
        /// </summary>
        public abstract Vector2D<int> Position { get; }

        /// <summary>
        /// Removes this <see cref="TileEntity"/> from the world.
        /// </summary>
        public abstract void Remove();
    }
}
