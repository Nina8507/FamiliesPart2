using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FamiliesPart2.Models
{
    public class Adult:Person
    {
        [JsonPropertyName("jobTitle")]
        public Job JobTitle { get; set; }
        [JsonPropertyName("adultId")]
        public override int Id { get; set; }
        [Required]
        [JsonPropertyName("firstName")]
        public override string FirstName { get; set; }
        [Required]
        [JsonPropertyName("lastName")]
        public override string LastName { get; set; }
        [JsonPropertyName("hairColor")]
        public override string HairColor { get; set; }
        [JsonPropertyName("age")]
        public override int Age { get; set; }
        [JsonPropertyName("weight")]
        public override float Weight { get; set; }
        [JsonPropertyName("height")]
        public override int Height { get; set; }
        [JsonPropertyName("sex")]
        public override string Sex { get; set; }
    }
}