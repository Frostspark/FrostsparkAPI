using Frostspark.API.Logging;

namespace Frostspark.API.Plugins
{
    public abstract class Plugin
    {
        /// <summary>
        /// This plugin's name
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// This plugin's author
        /// </summary>
        public abstract string Author { get; }

        /// <summary>
        /// The plugin's load order.
        /// </summary>
        public virtual int LoadOrder => 0;

        /// <summary>
        /// Whether or not this plugin is enabled.
        /// </summary>
        public bool Enabled { get; internal set; }

        /// <summary>
        /// Whether or not this plugin is loaded.
        /// </summary>
        public bool Loaded { get; internal set; }

        /// <summary>
        /// This plugin's logger.
        /// <para>Depending on server implementation, plugins might receive a different object than the root server logger, such as a localised/tagged logger.</para>
        /// </summary>
        public Logger Log { get; internal set; }

        /// <summary>
        /// Where this plugin is supposed to store its configuration files and other data.
        /// </summary>
        public string DataFolder { get; internal set; }

        /// <summary>
        /// Called when this plugin is enabled.
        /// </summary>
        public abstract void Enable();

        /// <summary>
        /// Called when this plugin is disabled.
        /// </summary>
        public abstract void Disable();

        /// <summary>
        /// Called when this plugin has been loaded.
        /// </summary>
        public abstract void Load();

        /// <summary>
        /// Called when this plugin is about to be unloaded.
        /// <para>You should take extreme care to end all activities not managed by Frostspark as to not block the unloading process as soon as this is called.</para>
        /// It is okay to block here for a couple of additional milliseconds, as Frostspark will request the GC to clean up your plugin causing a short stop anyway.
        /// </summary>
        public abstract void Unload();
    }
}
