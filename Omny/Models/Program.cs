using System.Text.Json.Serialization;

namespace Omny.Models
{
    public class Program
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Slug")]
        public string Slug { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("DescriptionHtml")]
        public string DescriptionHtml { get; set; }

        [JsonPropertyName("Author")]
        public string Author { get; set; }

        [JsonPropertyName("Publisher")]
        public object Publisher { get; set; }

        [JsonPropertyName("Copyright")]
        public object Copyright { get; set; }

        [JsonPropertyName("ArtworkUrl")]
        public string ArtworkUrl { get; set; }

        [JsonPropertyName("Category")]
        public string Category { get; set; }

        [JsonPropertyName("SocialWeb")]
        public string SocialWeb { get; set; }

        [JsonPropertyName("SocialTwitter")]
        public string SocialTwitter { get; set; }

        [JsonPropertyName("SocialFacebook")]
        public string SocialFacebook { get; set; }

        [JsonPropertyName("Hidden")]
        public bool Hidden { get; set; }

        [JsonPropertyName("Archived")]
        public bool Archived { get; set; }

        [JsonPropertyName("Network")]
        public object Network { get; set; }

        [JsonPropertyName("ExternalId")]
        public object ExternalId { get; set; }

        [JsonPropertyName("ContactName")]
        public string ContactName { get; set; }

        [JsonPropertyName("ContactEmail")]
        public string ContactEmail { get; set; }

        [JsonPropertyName("DefaultPlaylistId")]
        public string DefaultPlaylistId { get; set; }
    }
}