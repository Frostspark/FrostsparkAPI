using Frostspark.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Projectiles
{
    public class ProjectileUpdateEvent : ProjectileEvent
    {
        public ProjectileUpdateEvent(Projectile projectile, API.Server server) : base(projectile, server)
        {
        }
    }
}
