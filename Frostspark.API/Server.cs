using Frostspark.API.Chat;
using Frostspark.API.Collections;
using Frostspark.API.Entities;
using Frostspark.API.Events;
using Frostspark.API.Logging;
using Frostspark.API.Plugins;
using Frostspark.API.Scheduling;
using Frostspark.API.Utilities;

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

        Worlds.World World { get; }

        PluginManager Plugins { get; }

        Logger Log { get; }

        EventManager Events { get; }

        ChatManager Chat { get; }

        CLIParser CommandLine { get; }

        Scheduler Scheduler { get; }

        void Initialize();
    }
}
