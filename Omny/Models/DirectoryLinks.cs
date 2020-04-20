using System.Text.Json.Serialization;

namespace Omny.Models
{
    public class DirectoryLinks
    {
        [JsonPropertyName("ApplePodcasts")]
        public string ApplePodcasts { get; set; }

        [JsonPropertyName("GooglePodcasts")]
        public string GooglePodcasts { get; set; }

        [JsonPropertyName("Spotify")]
        public string Spotify { get; set; }

        [JsonPropertyName("Stitcher")]
        public string Stitcher { get; set; }

        [JsonPropertyName("TuneIn")]
        public string TuneIn { get; set; }

        [JsonPropertyName("GooglePlay")]
        public string GooglePlay { get; set; }

        [JsonPropertyName("RssFeed")]
        public string RssFeed { get; set; }
    }
}