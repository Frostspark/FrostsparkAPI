using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player is requesting to join the server.
    /// </summary>
    public class PlayerJoiningEvent : PlayerEvent
    {
        public PlayerJoiningEvent( Player player, API.Server server) : base(player, server)
        {

        }

        /// <summary>
        /// Result of the join request.
        /// <br/>
        /// - <see cref="PlayerJoiningResult.Continue"/> allows the server to process as normal. <br />
        /// - <see cref="PlayerJoiningResult.Wait"/> allows the event handler to manually continue the join process at a later time. <br />
        /// - <see cref="PlayerJoiningResult.Kick"/> removes the player from the server with the message specified in <see cref="KickMessage"/>.
        /// </summary>
        public PlayerJoiningResult Result { get; set; } = PlayerJoiningResult.Continue;

        /// <summary>
        /// What message to send if <see cref="Result"/> = <see cref="PlayerJoiningResult.Kick"/>
        /// </summary>
        public string KickMessage { get; set; }

        public enum PlayerJoiningResult
        {
            Continue,
            Wait,
            Kick
        }
    }
}
