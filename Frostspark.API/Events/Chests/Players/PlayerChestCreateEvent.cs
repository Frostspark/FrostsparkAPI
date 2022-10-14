using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chests.Players
{
    public sealed class PlayerChestCreateEvent : ChestCreateEvent, IHasSource<Player>
    {
        public PlayerChestCreateEvent(Player source, Rectangle area, ushort type, short style, API.Server server) : base(area, type, style, server)
        {
            Source = source;
        }

        public Player Source { get; }
    }
}
