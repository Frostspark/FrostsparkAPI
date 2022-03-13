using System;

namespace Frostspark.API.Plugins
{
    public class PluginCompatibilityInfo
    {
        /// <summary>
        /// The type of game engine this plugin requires.
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// What version of the game this plugin requires.
        /// </summary>
        public Version Version { get; set; }

        /// <summary>
        /// Defines how compatibility of the plugin is determined in relation to game version found.
        /// </summary>
        public PluginVersionCheckType VersionCheck { get; set; }

    }
}
