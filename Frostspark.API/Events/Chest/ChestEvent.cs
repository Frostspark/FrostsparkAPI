using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chest
{
    public abstract class ChestEvent : Event, IHasTarget<API.Entities.Chest>
    {
        public ChestEvent(API.Entities.Chest chest, API.Server server) : base(server)
        {
            Chest = chest;
        }

        public API.Entities.Chest Chest { get; }

        API.Entities.Chest IHasTarget<API.Entities.Chest>.Target => Chest;
    }
}
