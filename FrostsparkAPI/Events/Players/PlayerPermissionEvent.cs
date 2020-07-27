using Frostspark.API.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.Players
{
    public class PlayerPermissionEvent : Event
    {
        public PlayerPermissionEvent(API.Server server, Player player, string permission) : base(server)
        {
            Player = player;
            Permission = permission;
        }

        public Player Player { get; }

        public string Permission { get; }

        public PermissionResult Result { get; set; }

        public enum PermissionResult
        {
            None,
            Granted,
            Denied
        }
    }
}
