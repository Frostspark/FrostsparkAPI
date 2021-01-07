using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Server
{
    public class ServerPreUpdateEvent : Event
    {
        public ServerPreUpdateEvent(API.Server server) : base(server)
        {
        }
    }
}
