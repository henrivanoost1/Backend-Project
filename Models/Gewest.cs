using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Backend_Project.Models
{
    public class Gewest
    {
        public int GewestId { get; set; }


        public string Name { get; set; }

        [JsonIgnore]

        public List<Regioverantwoordelijke> Regioverantwoordelijken { get; set; }

        [JsonIgnore]
        public List<Afdeling> Afdelingen { get; set; }
    }
}
