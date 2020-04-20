using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Omny.Models
{
    public class Programs
    {
        [JsonPropertyName("Programs")]
        public IList<Program> List { get; set; }
    }
}