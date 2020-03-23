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
        /// Returns whether or not this event can be cancelled.
        /// </summary>
        public virtual bool Cancellable => false;

        private bool IsCancelled;

        /// <summary>
        /// Returns whether or not the event is cancelled, or sets its cancellation state.
        /// <para>Throws an exception if the event is not cancellable. Check <see cref="Cancellable"/> if you want to avoid exceptions.</para>
        /// </summary>
        public virtual bool Cancelled
        {
            get => Cancellable ? IsCancelled : throw new InvalidOperationException("This event is not cancellable!");
            set
            {
                if (Cancellable)
                    IsCancelled = value;
                else
                    throw new InvalidOperationException("This event is not cancellable!");
            }
        }

        /// <summary>
        /// Returns whether or not this event is asynchronous (that is, not fired by the main game thread)
        /// </summary>
        public virtual bool Asynchronous => false;
    }
}
