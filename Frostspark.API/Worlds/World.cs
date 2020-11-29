
using Frostspark.API.Enums;
using Frostspark.API.Worlds.Time;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Worlds
{
    /// <summary>
    /// Represents the game world - an abstract wrapper over Terraria's tile array, and associated properties.
    /// </summary>
    public abstract class World
    {
        /// <summary>
        /// Retrieves or sets a tile at given coordinates.
        /// </summary>
        /// <param name="x">The X coordinate</param>
        /// <param name="y">The Y coordinate</param>
        /// <returns>The tile at the given coordinates</returns>
        public abstract Tile this[int x, int y] { get; set; }

        /// <summary>
        /// The world's width (size in X axis)
        /// </summary>
        public abstract int Width { get; }

        /// <summary>
        /// The world's height (size in Y axis)
        /// </summary>
        public abstract int Height { get; }

        /// <summary>
        /// Gets or sets the world's name
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// Gets or sets the world's current time.
        /// </summary>
        public abstract WorldTime Time { get; set; }

        /// <summary>
        /// Gets or sets the world's difficulty type.
        /// </summary>
        public abstract WorldDifficulty Difficulty { get; set; }

        /// <summary>
        /// Gets or sets the world's hardmode value.
        /// </summary>
        public abstract bool Hardmode { get; set; }
    }
}
