using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Collections
{
    public abstract class ProjectileList : EntityList<API.Entities.Projectile>
    {
        /// <summary>
        /// Gets a projectile using the owner + identity pair.
        /// </summary>
        /// <param name="owner">The player who owns the projectile.</param>
        /// <param name="identity">The client-given identity ID of the projectile</param>
        /// <returns></returns>
        public abstract API.Entities.Projectile this[int owner, int identity]
        {
            get;
        }

    }
}
