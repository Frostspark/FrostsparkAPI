namespace Frostspark.API.Events
{
    public abstract class Event
    {
        protected Event(API.Server server)
        {
            Server = server;
        }

        /// <summary>
        /// Returns whether or not this event is asynchronous (that is, not fired by the main game thread)
        /// </summary>
        public virtual bool Asynchronous => false;

        /// <summary>
        /// Returns the instance of the server this event was raised on.
        /// </summary>
        public API.Server Server { get; private set; }
    }
}
