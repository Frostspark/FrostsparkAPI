namespace Frostspark.API.Events.Interfaces
{
    /// <summary>
    /// Represents an event that can be cancelled. An event, when cancelled, is not sent to server code for processing.
    /// </summary>
    public interface ICancellable : IEventHandlerCompatible
    {
        /// <summary>
        /// Whether or not this event is cancelled.
        /// </summary>
        bool Cancelled { get; set; }
    }
}
