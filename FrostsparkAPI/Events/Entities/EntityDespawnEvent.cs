using Frostspark.API.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Entities
{
    public class EntityDespawnEvent : EntityEvent, ICancellable
    {
        public EntityDespawnEvent(Entity ent, API.Server server) : base(ent, server)
        {
        }

        public bool Cancelled { get; set; }
    }
}
