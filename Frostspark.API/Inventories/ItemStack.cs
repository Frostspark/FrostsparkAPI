namespace Frostspark.API.Inventories
{
    /// <summary>
    /// Represents an item stack stored inside an inventory.
    /// <para>For items as world entities, see <see cref="Entities.DroppedItem"/></para>
    /// </summary>
    public abstract class ItemStack
    {
        /// <summary>
        /// The item's type.
        /// </summary>
        public abstract int Type { get; set; }

        /// <summary>
        /// The item stack's quantity.
        /// </summary>
        public abstract int Stack { get; set; }

        /// <summary>
        /// The item's maximum stack quantity.
        /// </summary>
        public abstract int MaxStack { get; }

        /// <summary>
        /// The item stack's prefix.
        /// </summary>
        public abstract byte Prefix { get; set; }
    }
}
