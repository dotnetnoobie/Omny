using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Omny.Models
{
    public class Playlist
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("Slug")]
        public string Slug { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("DescriptionHtml")]
        public string DescriptionHtml { get; set; }

        [JsonPropertyName("ProgramId")]
        public string ProgramId { get; set; }

        [JsonPropertyName("RssFeedUrl")]
        public string RssFeedUrl { get; set; }

        [JsonPropertyName("EmbedUrl")]
        public string EmbedUrl { get; set; }

        [JsonPropertyName("ArtworkUrl")]
        public string ArtworkUrl { get; set; }

        [JsonPropertyName("NumberOfClips")]
        public int NumberOfClips { get; set; }

        [JsonPropertyName("Visibility")]
        public string Visibility { get; set; }

        [JsonPropertyName("Categories")]
        public IList<string> Categories { get; set; }

        [JsonPropertyName("DirectoryLinks")]
        public DirectoryLinks DirectoryLinks { get; set; }
    }
}