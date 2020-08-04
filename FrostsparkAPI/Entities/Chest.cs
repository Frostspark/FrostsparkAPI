using Frostspark.API.Inventories;
using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Entities
{
    /// <summary>
    /// Represents a Terraria chest in the world.
    /// <para>In Terraria's code, any shared item storage is considered a chest.</para>
    /// </summary>
    public abstract class Chest
    {
        /// <summary>
        /// This chest's block type.
        /// </summary>
        public abstract int Type { get; }

        /// <summary>
        /// This chest's style (colour, biome).
        /// </summary>
        public abstract int Style { get; }

        /// <summary>
        /// This chest's native index.
        /// </summary>
        public abstract int Index { get; }

        /// <summary>
        /// This chest's position in the world.
        /// </summary>
        public abstract Vector2D<int> Position { get; }

        /// <summary>
        /// This chest's item inventory.
        /// </summary>
        public abstract Inventory Inventory { get; }

        /// <summary>
        /// This chest's name.
        /// </summary>
        public abstract string Name { get; }
    }
}
