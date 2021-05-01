using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Interfaces
{
    /// <summary>
    /// Represents an event that the client assumes to be completed without server input.
    /// Such events, if their outcome is modified, have to be re-transfered to the source player to resynchronise them.
    /// </summary>
    public interface IClientsided : IEventHandlerCompatible
    {
        /// <summary>
        /// Whether or not the event's properties have been modified, and need to be sent to the source client to resynchronise them.
        /// </summary>
        bool Modified { get; set; }
    }
}
