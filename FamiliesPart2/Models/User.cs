using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FamiliesPart2.Models
{
    public class User
    {
        [Required]
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [Required]
        [JsonPropertyName("role")]
        public string Role { get; set; }
        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("userId")]
        public int Id { get; set; }
    }
}