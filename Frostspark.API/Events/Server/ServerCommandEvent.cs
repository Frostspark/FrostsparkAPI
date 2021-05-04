using Frostspark.API.Events.Interfaces;

namespace Frostspark.API.Events.Server
{
    public abstract class ServerCommandEvent : Event, ICancellable
    {
        public ServerCommandEvent(string command, API.Server server) : base(server)
        {
            Command = command;
        }

        /// <summary>
        /// The command issued, without the prefix.
        /// </summary>
        public string Command { get; set; }

        public bool Cancelled { get; set; }
    }
}
