using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Interfaces
{
    /// <summary>
    /// Signifies the event has a target <typeparamref name="TargetType"/> entity that is impacted by this event.
    /// </summary>
    /// <typeparam name="TargetType"></typeparam>
    public interface IHasTarget<TargetType> : IEventHandlerCompatible
    {
        /// <summary>
        /// The entity this event modifies, targets or otherwise concerns.
        /// </summary>
        TargetType Target { get; }
    }
}
