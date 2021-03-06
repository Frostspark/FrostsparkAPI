﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public abstract class PlayerEvent : Event
    {
        protected PlayerEvent(API.Entities.Player player, API.Server server) : base(server)
        {
            Player = player;
        }

        public API.Entities.Player Player { get; }
    }
}
