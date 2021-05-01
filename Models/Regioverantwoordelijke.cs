using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Backend_Project.Models
{
    public class Regioverantwoordelijke
    {

        public Guid RegioverantwoordelijkeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Range(16, 80)]
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [JsonIgnore]
        public List<RegioverantwoordelijkeAfdeling> RegioverantwoordelijkenAfdeling { get; set; }

    }
}
