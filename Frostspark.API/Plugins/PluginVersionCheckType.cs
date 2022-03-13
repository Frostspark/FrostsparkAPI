namespace Frostspark.API.Plugins
{
    public enum PluginVersionCheckType
    {
        /// <summary>
        /// This plugin requires this version precisely.
        /// </summary>
        Exact,

        /// <summary>
        /// This plugin requires at least this version.
        /// </summary>
        EqualOrGreater
    }
}
