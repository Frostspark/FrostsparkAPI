namespace Frostspark.API.Collections
{
    public abstract class ProjectileList : EntityList<Entities.Projectile>
    {
        /// <summary>
        /// Gets a projectile using the owner + identity pair.
        /// </summary>
        /// <param name="owner">The player who owns the projectile.</param>
        /// <param name="identity">The client-given identity ID of the projectile</param>
        /// <returns></returns>
        public abstract Entities.Projectile this[int owner, int identity]
        {
            get;
        }

    }
}
