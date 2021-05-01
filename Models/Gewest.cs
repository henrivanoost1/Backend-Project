using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Backend_Project.Models
{
    public class Gewest
    {
        public Guid GewestId { get; set; }


        public string Name { get; set; }

        [JsonIgnore]

        public List<Regioverantwoordelijke> RegioverantwoordelijkeId { get; set; }

        public List<Afdeling> Afdelingen { get; set; }
    }
}
