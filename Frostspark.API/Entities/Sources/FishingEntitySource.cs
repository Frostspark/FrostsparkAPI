using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Entities.Sources
{
    public sealed class FishingEntitySource : EntitySource
    {
        public Entity Fisher { get; private set; }

        public Projectile Bobber { get; private set; }

        public FishingEntitySource(Entity fisher, Projectile bobber)
        {
            Fisher = fisher;
            Bobber = bobber;
        }
    }
}
