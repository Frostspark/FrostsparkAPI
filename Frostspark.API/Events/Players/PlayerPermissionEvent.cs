using Frostspark.API.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public PermissionResult Result { get; set; }

        public enum PermissionResult
        {
            None,
            Granted,
            Denied
        }
    }
}
