namespace Frostspark.API.Events
{
    public abstract class EventHandler<T> where T : Event
    {
        public virtual bool AllowCanceled => true;

        public virtual int Priority => 0;

        public abstract void Handle(T obj);
    }
}
