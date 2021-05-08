using Frostspark.API.Logging;

using System.Threading.Tasks;

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
        /// The plugins this plugin depends on.
        /// <para>This is used to determine load order within each <see cref="LoadOrder"/> tier.</para>
        /// </summary>
        public virtual string[] Dependencies => new string[0];

        /// <summary>
        /// The plugins that depend on this one.
        /// <para>This is used to determine load order within each <see cref="LoadOrder"/> tier.</para>
        /// This field is dedicated for plugins providing "enable-time services" to specific plugins dynamically.
        /// </summary>
        public virtual string[] Dependents => new string[0];

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
        public abstract Task Enable();

        /// <summary>
        /// Called when this plugin is disabled.
        /// </summary>
        public abstract Task Disable();

        /// <summary>
        /// Called when this plugin has been loaded.
        /// </summary>
        public abstract Task Load();

        /// <summary>
        /// Called when this plugin is about to be unloaded.
        /// <para>You should take extreme care to end all activities not managed by Frostspark as to not block the unloading process as soon as this is called.</para>
        /// It is okay to block here for a couple of additional milliseconds, as Frostspark will request the GC to clean up your plugin causing a short stop anyway.
        /// </summary>
        public abstract Task Unload();
    }
}
