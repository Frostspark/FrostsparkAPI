using Frostspark.API.Utilities;

namespace Frostspark.API.Entities
{
    /// <summary>
    /// Represents an instance of an entity in Terraria's engine.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Removes this entity.
        /// </summary>
        public abstract void Remove();

        /// <summary>
        /// This entity's name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// This entity's position in the world.
        /// </summary>
        public abstract Vector2D<float> Position { get; }

        /// <summary>
        /// This entity's velocity.
        /// </summary>
        public abstract Vector2D<float> Velocity { get; }

        /// <summary>
        /// This entity's native handle index.
        /// </summary>
        public abstract int Index { get; }

        /// <summary>
        /// Whether or not this entity is still in the game world.
        /// <para>This is not synonymous with the native index being active, but rather with one specific instance of it occupying this index.</para>
        /// This means that once this entity is removed, and its index reassigned, this will still return false.
        /// </summary>
        public abstract bool Active { get; }

    }
}
