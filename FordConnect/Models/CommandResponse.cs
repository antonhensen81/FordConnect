using Newtonsoft.Json;

namespace FordConnect.Models
{
    public class CommandResponse
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("commandId")]
        public string CommandId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

}
