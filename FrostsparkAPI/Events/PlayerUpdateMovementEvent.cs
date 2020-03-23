﻿using Frostspark.API.Classes;

namespace Frostspark.API.Events
{
    /// <summary>
    /// Fired when a player updates their movement variables (speed, position, and controls)
    /// <para>For visual player character updates, see <seealso cref="PlayerUpdateCharacterEvent"/></para>
    /// </summary>
    public class PlayerUpdateMovementEvent : Event
    {
        public Player Player { get; }


    }
}
