using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frostspark.API.Entities;

namespace Frostspark.API.Events.Entities
{
    public class EntitySpawnEvent : Event, ICancellable
    {
        public Entity Entity { get; private set; }

        public bool Cancelled { get; set; }
    }
}
