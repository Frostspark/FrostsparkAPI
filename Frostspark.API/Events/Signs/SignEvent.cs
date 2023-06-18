using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Signs
{
    public class SignEvent : Event, IHasTarget<Sign>
    {
        public SignEvent(Sign sign, API.Server server) : base(server)
        {
            Target = sign;
        }

        public Sign Target { get; }
    }
}
