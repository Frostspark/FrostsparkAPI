using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Signs
{
    public class SignTextEvent : SignEvent, ICancellable
    {
        public SignTextEvent(string text, Sign sign, API.Server server) : base(sign, server)
        {
            NewText = text;
        }

        /// <summary>
        /// New text being set to this sign.
        /// </summary>
        public string NewText { get; set; }

        public bool Cancelled { get; set; }
    }
}
