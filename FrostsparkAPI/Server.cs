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
    public interface Server
    {
        EntityList<Player> Players { get; }

        EntityList<NPC> NPCs { get; }

        ProjectileList Projectiles { get; }

        EntityList<DroppedItem> Items { get; }

        World.World World { get; }

        PluginManager Plugins { get; }

        Logger Log { get; }

        EventManager Events { get; }

        void Initialize();
    }
}
