using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Server
{
    public abstract class ServerCommandEvent : Event, ICancellable
    {
        public ServerCommandEvent(string command, API.Server server) : base(server)
        {

        }

        /// <summary>
        /// The command issued, without the prefix.
        /// </summary>
        public string Command { get; set; }

        public bool Cancelled { get; set; }
    }
}
