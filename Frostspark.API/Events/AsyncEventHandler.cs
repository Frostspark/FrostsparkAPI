﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events
{
    public abstract class AsyncEventHandler<T> : AsyncEventHandler where T : Event
    {
        public sealed override ValueTask HandleEvent(Event e)
        {
            if (e is T t)
            {
                return Handle(t);
            }

            return ValueTask.CompletedTask;
        }

        public abstract ValueTask Handle(T obj);

        public override Type EventType => typeof(T);
    }

    public abstract class AsyncEventHandler : EventHandler
    {
        public abstract ValueTask HandleEvent(Event e);

        /// <summary>
        /// If set to true, this will suppress the server engine warnings about asynchronous code being called in synchronous event invokes without awaiting them.
        /// <para>Only set this if you're **ABSOLUTELY CERTAIN** you know what you're doing, and have considered the consequences of your await continuation running long after the event invoker checked the result.</para>
        /// </summary>
        public virtual bool SuppressSyncInvokeWarning { get; } = false;
    }
}
