using System.Text.Json.Serialization;

namespace Omny.Models
{
    public class Chapter
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Position")]
        public string Position { get; set; }
    }
}