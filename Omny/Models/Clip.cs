using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Omny.Models
{
    public class Clip
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

        [JsonPropertyName("Tags")]
        public IList<object> Tags { get; set; }

        [JsonPropertyName("Season")]
        public object Season { get; set; }

        [JsonPropertyName("Episode")]
        public int? Episode { get; set; }

        [JsonPropertyName("EpisodeType")]
        public string EpisodeType { get; set; }

        [JsonPropertyName("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("AudioUrl")]
        public string AudioUrl { get; set; }

        [JsonPropertyName("VideoUrl")]
        public object VideoUrl { get; set; }

        [JsonPropertyName("EmbedUrl")]
        public string EmbedUrl { get; set; }

        [JsonPropertyName("DurationSeconds")]
        public double DurationSeconds { get; set; }

        [JsonPropertyName("PublishState")]
        public string PublishState { get; set; }

        [JsonPropertyName("PublishedUrl")]
        public string PublishedUrl { get; set; }

        [JsonPropertyName("Visibility")]
        public string Visibility { get; set; }

        [JsonPropertyName("PublishedUtc")]
        public string PublishedUtc { get; set; }

        [JsonPropertyName("PlaylistIds")]
        public IList<string> PlaylistIds { get; set; }

        [JsonPropertyName("Chapters")]
        public IList<Chapter> Chapters { get; set; }

        [JsonPropertyName("State")]
        public string State { get; set; }

        [JsonPropertyName("ShareUrl")]
        public object ShareUrl { get; set; }

        [JsonPropertyName("ImportedId")]
        public object ImportedId { get; set; }

        [JsonPropertyName("Monetization")]
        public Monetization Monetization { get; set; }

        [JsonPropertyName("RecordingMetadata")]
        public object RecordingMetadata { get; set; }

        [JsonPropertyName("ProgramId")]
        public string ProgramId { get; set; }

        [JsonPropertyName("PublishedAudioSizeInBytes")]
        public int PublishedAudioSizeInBytes { get; set; }

        [JsonPropertyName("ContentRating")]
        public string ContentRating { get; set; }

        [JsonPropertyName("AudioOptions")]
        public AudioOptions AudioOptions { get; set; }
    }
}