using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Backend_Project.Models
{
    public class Regioverantwoordelijke
    {

        public int RegioverantwoordelijkeId { get; set; }


        public string Name { get; set; }


        public string FirstName { get; set; }


        public int Age { get; set; }


        public string Email { get; set; }

        public int GewestId { get; set; }

        public Gewest Gewest { get; set; }

        [JsonIgnore]
        public IList<RegioverantwoordelijkeAfdeling> RegioverantwoordelijkeAfdelingen { get; set; }



    }
}
