using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Omny.Models
{
    public class Playlists 
    {
        [JsonPropertyName("Playlists")]
        public IList<Playlist> List { get; set; }
    }
}