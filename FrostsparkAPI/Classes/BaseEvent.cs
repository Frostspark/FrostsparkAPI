using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events
{
    public abstract class BaseEvent
    {
        /// <summary>
        /// Returns whether or not this event can be cancelled.
        /// </summary>
        public abstract bool Cancellable { get; }

        /// <summary>
        /// Returns whether or not the event is cancelled, or sets its cancellation state.
        /// </summary>
        public abstract bool IsCancelled { get; set; }

    }
}
