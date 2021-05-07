using System.Text.Json.Serialization;

namespace FamiliesPart2.Models
{
    public class Interest
    {
        [JsonPropertyName("interestId")]
        public int Id { get; set; }
        [JsonPropertyName("interestType")]
        public string Type { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}