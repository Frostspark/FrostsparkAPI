using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Entities.Sources
{
    public sealed class ParentEntitySource : EntitySource
    {
        public Entity Parent { get; private set; }

        public ParentEntitySource(Entity parent)
        {
            Parent = parent;
        }
    }
}
