using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FamiliesPart2.Models
{
    public class Family
    {
        [JsonPropertyName("familyId")]
        public int Id { get; set; }
        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }
        [JsonPropertyName("houseNumber")]
        public int HouseNumber{ get; set; }
        [Required]
        public List<Adult> Adults { get; set; }
        [Required]
        public List<Child> Children{ get; set; }
        public List<Pet> Pets{ get; set; }
        
        public Family() 
        {
            Adults = new List<Adult>();
            Children = new List<Child>();
            Pets = new List<Pet>();
        }
    }
}
