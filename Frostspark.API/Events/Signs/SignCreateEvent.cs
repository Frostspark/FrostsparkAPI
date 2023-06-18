using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Signs
{
    public class SignCreateEvent : SignEvent, ICancellable
    {
        public SignCreateEvent(Rectangle area, ushort type, byte style, API.Server server) : base(null, server)
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
