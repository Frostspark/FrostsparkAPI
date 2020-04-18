using Frostspark.API.Utilities;

namespace Frostspark.API.Entities
{
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
        public Vector2D<float> Position { get; }

        /// <summary>
        /// This entity's velocity.
        /// </summary>
        public Vector2D<float> Velocity { get; }

    }
}
