using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chest
{
    public abstract class ChestEvent : Event
    {
        public ChestEvent(API.Entities.Chest chest, API.Server server) : base(server)
        {
            Chest = chest;
        }

        public API.Entities.Chest Chest { get; }
    }
}
