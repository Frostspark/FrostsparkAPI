using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Frostspark.API.Events.Players
{
    public class PlayerChatEvent : PlayerEvent, ICancellable
    {
        public PlayerChatEvent(Player player, API.Server server) : base(player, server)
        {
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
        /// The base color of the chat message
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// A list of players that will receive this message.
        /// </summary>
        public IList<Player> Recipients { get; set; }

        public bool Cancelled { get; set; }
    }
}
