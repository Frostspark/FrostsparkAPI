using Frostspark.API.Entities;
using Frostspark.API.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public class PlayerMoveEvent : PlayerEvent, ICancellable
    {
        public PlayerMoveEvent(Player player, API.Server server, Vector2D<float> from_position, Vector2D<float> to_position, bool is_implicit) : base(player, server)
        {
            Implicit = is_implicit;
            OldPosition = from_position;
            NewPosition = to_position;
        }

        /// <summary>
        /// Whether or not this move event is implicit (server simulation) or explicit (netcode induced)
        /// </summary>
        public bool Implicit { get; }

        /// <summary>
        /// Where this player moved from.
        /// </summary>
        public Vector2D<float> OldPosition { get; private set; }

        /// <summary>
        /// Where this player has moved to.
        /// </summary>
        public Vector2D<float> NewPosition { get; set; }

        public bool Cancelled { get; set; }
    }
}
