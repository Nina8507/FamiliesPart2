using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FamiliesPart2.Models
{
    public class Child:Person
    {
        public List<Interest> Interests { get; set; }
        public List<Pet> Pets { get; set; }
        [Key]
        [JsonPropertyName("childId")]
        public int Id { get; set; }
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