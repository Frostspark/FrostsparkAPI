namespace Frostspark.API.Events.Interfaces
{
    /// <summary>
    /// Signifies the event has a source entity <typeparamref name="SourceType"/> that is the source of this event.
    /// </summary>
    /// <typeparam name="SourceType"></typeparam>
    public interface IHasSource<SourceType> : IEventHandlerCompatible
    {
        /// <summary>
        /// The source/initiator of this event.
        /// </summary>
        SourceType Source { get; }
    }
}
