using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Omny.Models
{
    public class Monetization
    {
        [JsonPropertyName("PreRoll")]
        public bool PreRoll { get; set; }

        [JsonPropertyName("PostRoll")]
        public bool PostRoll { get; set; }

        [JsonPropertyName("MidRolls")]
        public IList<string> MidRolls { get; set; }
    }
}