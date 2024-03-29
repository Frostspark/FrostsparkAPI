﻿using Frostspark.API.Entities;

namespace Frostspark.API.Events.Players
{
    public class PlayerPermissionEvent : PlayerEvent
    {
        public PlayerPermissionEvent(API.Server server, Player player, string permission) : base(player, server)
        {
            Permission = permission;
        }

        /// <summary>
        /// The permission node being checked.
        /// </summary>
        public string Permission { get; }

        /// <summary>
        /// The result of the permission check.
        /// </summary>
        public PermissionResult Result { get; set; } = PermissionResult.None;

        public enum PermissionResult
        {
            None,
            Granted,
            Denied
        }
    }
}
