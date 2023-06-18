using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Signs.Players
{
    public sealed class PlayerSignCreateEvent : SignCreateEvent, IHasSource<Player>
    {
        public PlayerSignCreateEvent(Player player, Rectangle area, ushort type, byte style, API.Server server) : base(area, type, style, server)
        {
            Source = player;
        }

        public Player Source { get; }
    }
}
