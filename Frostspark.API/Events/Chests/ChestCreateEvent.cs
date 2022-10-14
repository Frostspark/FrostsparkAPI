using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Chests
{
    public class ChestCreateEvent : ChestEvent, ICancellable
    {
        public ChestCreateEvent(Rectangle area, ushort type, short style, API.Server server) : base(null, server)
        {
            Area = area;
            Type = type;
            Style = style;
        }

        public bool Cancelled { get; set; }

        public ushort Type { get; set; }

        public short Style { get; set; }

        public Rectangle Area { get; set; }
    }
}
