using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Backend_Project.Models
{
    public class Regioverantwoordelijke
    {

        public Guid RegioverantwoordelijkeId { get; set; }


        public string Name { get; set; }


        public string FirstName { get; set; }


        public int Age { get; set; }


        public string Email { get; set; }

        [JsonIgnore]
        public List<RegioverantwoordelijkeAfdeling> RegioverantwoordelijkenAfdeling { get; set; }

    }
}
