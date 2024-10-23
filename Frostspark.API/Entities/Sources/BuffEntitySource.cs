using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Entities.Sources
{
    public sealed class BuffEntitySource : EntitySource
    {
        public Entity Entity { get; private set; }

        public int BuffType { get; private set; }

        public int BuffIndex { get; private set; }

        public BuffEntitySource(Entity entity, int buff_type, int buff_index)
        {
            Entity = entity;
            BuffType = buff_type;
            BuffIndex = buff_index;
        }

    }
}
