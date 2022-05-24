using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Utilities;

using System.Collections.Generic;

namespace Frostspark.API.Events.Server
{
    public class ServerChatEvent : Event, ICancellable, IHasSource<Player>
    {
        public ServerChatEvent(Player player, string message, string format, Color color, List<Player> audience, API.Server server) : base(server)
        {
            Player = player;
            Message = message;
            Format = format;
            Color = color;
            Recipients = audience;
        }

        /// <summary>
        /// The message the player sent.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The chat format string the message will use.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Whether or not the <see cref="Format"/> field contains a format string, or the entire ready-to-send chat message.
        /// </summary>
        public bool IsPreformatted { get; set; }

        /// <summary>
        /// The base color of the chat message
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// The list of players that will receive this message.
        /// </summary>
        public IList<Player> Recipients { get; set; }

        public bool Cancelled { get; set; }

        public Player Player { get; }

        Player IHasSource<Player>.Source => Player;
    }
}
