using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Backend_Project.Models
{
    public class RegioverantwoordelijkeAfdeling
    {
        [Key]

        public int RegioverantwoordelijkeAfdelingId { get; set; }
        public int RegioverantwoordelijkeId { get; set; }

        // public Regioverantwoordelijke Regioverantwoordelijke { get; set; }

        public int AfdelingId { get; set; }

        // public Afdeling Afdeling { get; set; }

    }
}
