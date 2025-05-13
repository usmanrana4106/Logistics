using System.Text.Json.Serialization;

namespace logistics.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DriverStatus
    {
        active = 1,
        notActive = 2
    }
}