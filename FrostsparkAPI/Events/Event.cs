using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Classes.Events
{
    public abstract class Event
    {
        /// <summary>
        /// Returns whether or not this event is asynchronous (that is, not fired by the main game thread)
        /// </summary>
        public virtual bool Asynchronous => false;
    }
}
