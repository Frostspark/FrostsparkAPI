using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Projectiles
{
    public abstract class ProjectileEvent : Event, IHasTarget<Projectile>
    {
        protected ProjectileEvent(Projectile projectile, API.Server server) : base(server)
        {
            Projectile = projectile;
        }

        public Projectile Projectile { get; }

        Projectile IHasTarget<Projectile>.Target => Projectile;
    }
}
