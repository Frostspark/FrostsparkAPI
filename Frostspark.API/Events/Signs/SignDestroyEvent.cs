using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Signs
{
    public class SignDestroyEvent : SignEvent, ICancellable
    {
        public SignDestroyEvent(Sign sign, API.Server server) : base(sign, server)
        {
        }

        public bool Cancelled { get; set; }
    }
}
