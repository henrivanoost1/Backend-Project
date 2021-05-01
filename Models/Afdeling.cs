using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Backend_Project.Models
{
    public class Afdeling
    {
        public Guid AfdelingId { get; set; }


        public string Name { get; set; }


        public string Gemeente { get; set; }

        [JsonIgnore]
        public List<RegioverantwoordelijkeAfdeling> RegioverantwoordelijkeAfdeling { get; set; }
        public List<Lid> Leden { get; set; }

    }
}
