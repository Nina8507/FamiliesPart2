using System.Text.Json.Serialization;

namespace FamiliesPart2.Models
{
    public class Job
    {
        
        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }
        [JsonPropertyName("salary")]
        public int Salary { get; set; }
        [JsonPropertyName("jobId")]
        public int Id { get; set; }
    }
}