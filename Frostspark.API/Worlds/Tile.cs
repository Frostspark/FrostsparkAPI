using Frostspark.API.Enums;
using Frostspark.API.Utilities;

namespace Frostspark.API.Worlds
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
        /// The tile's foreground block texture frame
        /// </summary>
        public abstract Vector2D<short> Frame { get; set; }

        /// <summary>
        /// The tile's wall texture frame
        /// </summary>
        public abstract Vector2D<short> WallFrame { get; set; }

        /// <summary>
        /// The tile's health.
        /// </summary>
        public abstract byte Health { get; set; }

        /// <summary>
        /// The tile's active status (whether or not there's a foreground tile there)
        /// </summary>
        public abstract bool Active { get; set; }

        /// <summary>
        /// The tile's wire manager
        /// </summary>
        public abstract TileWire Wire { get; }

        /// <summary>
        /// The tile's actuator status
        /// </summary>
        public abstract bool Actuator { get; set; }

        /// <summary>
        /// The tile's block type
        /// </summary>
        public abstract BlockShape Shape { get; set; }

        /// <summary>
        /// The tile's actuation status (disabled collisions)
        /// </summary>
        public bool Actuated { get; set; }

        /// <summary>
        /// The foreground block's paint
        /// </summary>
        public BlockPaint Paint { get; set; }

        /// <summary>
        /// The wall paint
        /// </summary>
        public BlockPaint WallPaint { get; set; }

    }
}
