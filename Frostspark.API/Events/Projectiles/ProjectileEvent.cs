using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Projectiles
{
    public abstract class ProjectileEvent : Event, IHasTarget<Projectile>
    {
        protected ProjectileEvent(API.Entities.Projectile projectile, API.Server server) : base(server)
        {
            Projectile = projectile;
        }

        public API.Entities.Projectile Projectile { get; }

        Projectile IHasTarget<Projectile>.Target => Projectile;
    }
}
