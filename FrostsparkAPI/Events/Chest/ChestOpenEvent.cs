using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chest
{
    public class ChestOpenEvent : ChestEvent, ICancellable
    {
        public ChestOpenEvent(API.Entities.Player player, API.Entities.Chest chest, API.Server server) : base(chest, server)
        {
            Player = player;
        }

        /// <summary>
        /// The player opening the chest.
        /// </summary>
        public API.Entities.Player Player { get; }

        /// <summary>
        /// Whether or not the opening action is canceled.
        /// </summary>
        public bool Cancelled { get; set; }
    }
}
