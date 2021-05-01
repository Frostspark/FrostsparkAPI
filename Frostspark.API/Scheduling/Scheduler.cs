using Frostspark.API.Plugins;

using System;

namespace Frostspark.API.Scheduling
{
    public abstract class Scheduler
    {
        /// <summary>
        /// Schedules a task to run synchronously next frame.
        /// </summary>
        /// <param name="act"></param>
        /// <returns>An object ticket that can be used to cancel the task.</returns>
        public abstract object RunTask(Plugin plugin, Action action);

        /// <summary>
        /// Schedules a task to run synchronously in <paramref name="ticks"/> server frames.
        /// </summary>
        /// <param name="plugin"></param>
        /// <param name="action"></param>
        /// <param name="ticks"></param>
        /// <returns></returns>
        public abstract object RunTaskTicks(Plugin plugin, Action action, ulong ticks);

        /// <summary>
        /// Schedules a task to run synchronously in <paramref name="time"/> seconds.
        /// </summary>
        /// <param name="plugin"></param>
        /// <param name="action"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public abstract object RunTask(Plugin plugin, Action action, double time);

        /// <summary>
        /// Schedules a task to run synchronously in <paramref name="time"/> seconds, then repeating every <paramref name="period"/> seconds.
        /// </summary>
        /// <param name="plugin"></param>
        /// <param name="action"></param>
        /// <param name="time"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        public abstract object RunTask(Plugin plugin, Action action, double time, double period);

        /// <summary>
        /// Schedules a task to run synchronously in <paramref name="ticks"/> server frames, then repeating every <paramref name="period"/> server frames.
        /// </summary>
        /// <param name="plugin"></param>
        /// <param name="action"></param>
        /// <param name="time"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        public abstract object RunTaskTicks(Plugin plugin, Action action, ulong ticks, ulong period);

        /// <summary>
        /// Schedules a task to run asynchronously next frame.
        /// </summary>
        /// <param name="act"></param>
        /// <returns>An object ticket that can be used to cancel the task.</returns>
        public abstract object RunTaskAsync(Plugin plugin, Action action);

        /// <summary>
        /// Schedules a task to run asynchronously in <paramref name="ticks"/> server frames.
        /// </summary>
        /// <param name="plugin"></param>
        /// <param name="action"></param>
        /// <param name="ticks"></param>
        /// <returns></returns>
        public abstract object RunTaskTicksAsync(Plugin plugin, Action action, ulong ticks);

        /// <summary>
        /// Schedules a task to run asynchronously in <paramref name="time"/> seconds.
        /// </summary>
        /// <param name="plugin"></param>
        /// <param name="action"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public abstract object RunTaskAsync(Plugin plugin, Action action, double time);

        /// <summary>
        /// Schedules a task to run asynchronously in <paramref name="time"/> seconds, then repeating every <paramref name="period"/> seconds.
        /// </summary>
        /// <param name="plugin"></param>
        /// <param name="action"></param>
        /// <param name="time"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        public abstract object RunTaskAsync(Plugin plugin, Action action, double time, double period);

        /// <summary>
        /// Schedules a task to run asynchronously in <paramref name="ticks"/> server frames, then repeating every <paramref name="period"/> server frames.
        /// </summary>
        /// <param name="plugin"></param>
        /// <param name="action"></param>
        /// <param name="time"></param>
        /// <param name="period"></param>
        /// <returns></returns>
        public abstract object RunTaskTicksAsync(Plugin plugin, Action action, ulong ticks, ulong period);

        /// <summary>
        /// Cancels a task using an object ticket.
        /// </summary>
        /// <param name="ticket">The ticket object given by task scheduling methods in this class</param>
        /// <returns></returns>
        public abstract void CancelTask(object ticket);
    }
}
