using System.Text.Json.Serialization;

namespace Omny.Models
{
    public class AudioOptions
    {
        [JsonPropertyName("IncludeIntroOutro")]
        public bool IncludeIntroOutro { get; set; }

        [JsonPropertyName("AutoLevelAudio")]
        public bool AutoLevelAudio { get; set; }
    }
}