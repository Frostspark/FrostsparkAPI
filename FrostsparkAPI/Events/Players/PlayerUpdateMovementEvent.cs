﻿using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    /// <summary>
    /// Fired when a player updates their movement variables (speed, position, and controls)
    /// <para>For visual player character updates, see <seealso cref="PlayerUpdateCharacterEvent"/></para>
    /// </summary>
    public class PlayerUpdateMovementEvent : Event
    {
        public PlayerUpdateMovementEvent(API.Server server) : base(server)
        {
        }

        public Player Player { get; }
    }
}
