namespace Frostspark.API.Entities
{
    /// <summary>
    /// Represents a wrapped Terraria projectile object.
    /// </summary>
    public abstract class Projectile : Entity
    {
        /// <summary>
        /// This projectile's owner
        /// <para>A null value means the projectile has no owning player/is owned by the server or an NPC.</para>
        /// </summary>
        public abstract Player Owner { get; }

        /// <summary>
        /// This projectile's client-given identity number.
        /// </summary>
        public abstract int Identity { get; }
    }
}
