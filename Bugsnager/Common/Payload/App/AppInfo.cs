using Newtonsoft.Json;

namespace Bugsnager.Payload.App
{
    /// <summary>
    /// Contains information about the app that crashed
    /// </summary>
    internal class AppInfo
    {
        /// <summary>
        /// Gets or sets the version number of the application (optional)
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the release stage of the application e.g. development, production (optional)
        /// </summary>
        [JsonProperty("releaseStage")]
        public string ReleaseStage { get; set; }
    }
}