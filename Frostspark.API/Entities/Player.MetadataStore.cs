using Frostspark.API.Plugins;

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Frostspark.API.Entities
{
    public abstract partial class Player
    {
        internal class MetadataStore
        {
            private readonly Dictionary<Plugin, Dictionary<string, object>> PluginMetadata;

            private readonly Dictionary<string, object> GlobalMetadata;

            private readonly Dictionary<Plugin, List<string>> PluginsToGlobals;

            private readonly Dictionary<string, Plugin> GlobalsToPlugins;

            internal MetadataStore()
            {
                PluginMetadata = new Dictionary<Plugin, Dictionary<string, object>>();
                GlobalMetadata = new Dictionary<string, object>();
                PluginsToGlobals = new Dictionary<Plugin, List<string>>();
                GlobalsToPlugins = new Dictionary<string, Plugin>();
            }

            public void SetLocalValue<T>(Plugin plugin, string key, T value)
            {
                if (!PluginMetadata.TryGetValue(plugin, out var meta))
                    PluginMetadata[plugin] = meta = new Dictionary<string, object>();

                meta[key] = value;
            }

            public bool GetLocalValue<T>(Plugin plugin, string key, out T value)
            {
                value = default;

                if (!PluginMetadata.TryGetValue(plugin, out var meta))
                    return false;

                if (!meta.TryGetValue(key, out object val))
                    return false;

                if (!(val is T tval))
                    return false;

                value = tval;
                return true;
            }

            public bool GetLocalValue(Plugin plugin, string key, out object value)
            {
                value = null;

                if (!PluginMetadata.TryGetValue(plugin, out var meta))
                    return false;

                return meta.TryGetValue(key, out value);
            }

            public bool ClearLocalValue(Plugin plugin, string key)
            {
                if (!PluginMetadata.TryGetValue(plugin, out var meta))
                    return false;

                return meta.Remove(key);
            }

            public void SetGlobalValue<T>(Plugin plugin, string key, T value)
            {
                UpdateGlobalOwnership(key, plugin);

                GlobalMetadata[key] = value;
            }

            public bool GetGlobalValue<T>(string key, out T value)
            {
                value = default;
                if(GlobalMetadata.TryGetValue(key, out object val))
                {
                    if (!(val is T tval))
                        return false;

                    value = tval;
                    return true;
                }

                return false;
            }

            public bool GetGlobalValue(string key, out object value)
            {
                return GlobalMetadata.TryGetValue(key, out value);
            }

            public bool ClearGlobalValue(string key)
            {
                UpdateGlobalOwnership(key, null);

                return GlobalMetadata.Remove(key);
            }

            private void UpdateGlobalOwnership(string key, Plugin new_owner)
            {
                if(GlobalsToPlugins.TryGetValue(key, out Plugin owner))
                {
                    if (owner == new_owner)
                        return;

                    PluginsToGlobals[owner].Remove(key);

                    if (new_owner == null)
                        return;

                    if (!PluginsToGlobals.TryGetValue(new_owner, out var globals))
                        PluginsToGlobals[new_owner] = globals = new List<string>();

                    globals.Add(key);

                    GlobalsToPlugins[key] = new_owner;
                }
            }

            internal void ClearPluginData(Plugin plugin)
            {
                PluginMetadata.Remove(plugin);

                if(PluginsToGlobals.TryGetValue(plugin, out List<string> globals))
                {
                    foreach(var global in globals)
                    {
                        GlobalsToPlugins.Remove(global);
                        GlobalMetadata.Remove(global);
                    }
                }

            }
        }
    }
}
