using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events
{
    /// <summary>
    /// Represents an event that can be cancelled. An event, when cancelled, is not sent to server code for processing.
    /// </summary>
    public interface ICancellable
    {
        /// <summary>
        /// Whether or not this event is cancelled.
        /// </summary>
        bool Cancelled { get; set; }
    }
}
