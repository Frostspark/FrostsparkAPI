using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Entities.Sources
{
    public sealed class DropAsItemEntitySource : EntitySource
    {
        public Entity Entity { get; private set; }

        public DropAsItemEntitySource(Entity entity)
        {
            Entity = entity;
        }
    }
}
