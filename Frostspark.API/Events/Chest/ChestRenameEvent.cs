using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chest
{
    public class ChestRenameEvent : ChestEvent, ICancellable
    {
        public ChestRenameEvent(API.Entities.Player player, API.Entities.Chest chest, API.Server server) : base(chest, server)
        {
            Player = player;
        }

        public API.Entities.Player Player { get; }

        public string NewName { get; set; }

        public bool Cancelled { get; set; }
    }
}
