using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Omny.Models
{
    public class Clips 
    {
        [JsonPropertyName("Clips")]
        public IList<Clip> List { get; set; }

        [JsonPropertyName("Cursor")]
        public string Cursor { get; set; }

        [JsonPropertyName("TotalCount")]
        public int TotalCount { get; set; }
    }
}