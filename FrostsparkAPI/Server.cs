using Frostspark.API.Collections;
using Frostspark.API.Entities;
using Frostspark.API.Events;
using Frostspark.API.Logging;
using Frostspark.API.Plugins;

namespace Frostspark.API
{
    /// <summary>
    /// Represents an underlying server engine.
    /// </summary>
    public abstract class Server
    {
        public abstract EntityList<Player> Players { get; }

        public abstract EntityList<NPC> NPCs { get; }

        public abstract ProjectileList Projectiles { get; }

        public abstract EntityList<Item> Items { get; }

        public abstract PluginManager Plugins { get; }

        public abstract Logger Log { get; }

        public abstract EventManager Events { get; }

        public abstract void Initialize();
    }
}
