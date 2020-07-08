namespace Frostspark.API.Entities
{
    /// <summary>
    /// Represents a Terraria item <see cref="Entity"/> in the world.
    /// </summary>
    public abstract class Item : Entity
    {

        /// <summary>
        /// The player that currently owns this item.
        /// <para>This refers to the player that can currently edit the item's properties.</para>
        /// </summary>
        public abstract Player Owner { get; }

    }
}
