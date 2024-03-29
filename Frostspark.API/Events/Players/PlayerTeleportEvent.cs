﻿
using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Utilities;

namespace Frostspark.API.Events.Players
{
    public class PlayerTeleportEvent : PlayerEvent, ICancellable, IClientsided
    {
        public PlayerTeleportEvent(Player player, API.Server server) : base(player, server)
        {
        }

        /// <summary>
        /// The location where the player will end up.
        /// </summary>
        public Vector2D<float> Destination { get; set; }

        /// <summary>
        /// The velocity the player will have after the teleportation occurs.
        /// </summary>
        public Vector2D<float> NewVelocity { get; set; }

        public bool Cancelled { get; set; }

        /// <summary>
        /// The method used by this player to teleport.
        /// </summary>
        public PlayerTeleportationMethod Method { get; }

        public bool Modified { get; set; }

        public enum PlayerTeleportationMethod
        {
            /// <summary>
            /// Teleportation via recall potion, or other recall items, like magic mirror and upgrades.
            /// </summary>
            Recall,
            /// <summary>
            /// Teleportation via Rod of Discord.
            /// </summary>
            RodOfDiscord,
            /// <summary>
            /// Teleportation via a Teleportation Potion
            /// </summary>
            TeleportationPotion,
            /// <summary>
            /// Teleportation via entering a portal.
            /// </summary>
            Portal,
            /// <summary>
            /// Teleportation via using a wired teleporter.
            /// </summary>
            Teleporter,
            /// <summary>
            /// Teleportation via the server API.
            /// </summary>
            API,
            /// <summary>
            /// Teleportation via unknown causes.
            /// </summary>
            Unknown
        }
    }
}
