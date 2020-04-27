using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public class PlayerUpdateInventoryEvent : Event
    {
        public PlayerUpdateInventoryEvent(API.Server server) : base(server)
        {
        }


    }
}
