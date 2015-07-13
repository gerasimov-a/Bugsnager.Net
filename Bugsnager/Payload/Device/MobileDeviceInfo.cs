using Newtonsoft.Json;

namespace Bugsnager.Payload.Device
{
    public class MobileDeviceInfo
    {
        /// <summary>
        /// Gets or sets the version of operating system (optional)
        /// </summary>
        [JsonProperty("osVersion")]
        public string OSVersion { get; set; }

        /// <summary>
        /// Gets the name of mobile operator
        /// </summary>
        [JsonProperty("mobileOperator")]
        public string MobileOperator { get; set; }

        /// <summary>
        /// Gets the type of connection (wifi or 3g)
        /// </summary>
        [JsonProperty("connectionType")]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets the model of the device 
        /// </summary>
        [JsonProperty("deviceModel")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Gets the region of the device 
        /// </summary>
        [JsonProperty("deviceRegion")]
        public string DeviceGeographicRegion { get; set; }

        /// <summary>
        /// Gets the manufacturer of the device 
        /// </summary>
        [JsonProperty("deviceManufacturer")]
        public string DeviceManufacturer { get; set; }

        /// <summary>
        /// Gets the device timezone
        /// </summary>
        [JsonProperty("deviceTimeZone")]
        public string DeviceTimezone { get; set; }

        /// <summary>
        /// Gets the device timezone
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
    }
}
