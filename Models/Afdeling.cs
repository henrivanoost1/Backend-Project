using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Backend_Project.Models
{
    public class Afdeling
    {
        public int AfdelingId { get; set; }


        public string Name { get; set; }


        public string Gemeente { get; set; }

        [JsonIgnore]
        public List<Lid> Leden { get; set; }

        public int GewestId { get; set; }

        public Gewest Gewest { get; set; }

        [JsonIgnore]
        public IList<RegioverantwoordelijkeAfdeling> RegioverantwoordelijkeAfdelingen { get; set; }


    }
}
