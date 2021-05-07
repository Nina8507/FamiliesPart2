using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FamiliesPart2.Models
{
    public class Pet
    {
        [Key]
        [JsonPropertyName("petId")]
        public int Id { get; set; }
        [JsonPropertyName("species")]
        public string Species { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("age")]
        public int Age { get; set; }
    }
}