using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Server
{
    public class ServerWatchdogEvent : Event, IAsynchronous
    {
        public ServerWatchdogEvent(API.Server server) : base(server)
        {
        }
    }
}
