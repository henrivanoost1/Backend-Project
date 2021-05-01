using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Backend_Project.Models
{
    public class Lid
    {
        public Guid LidId { get; set; }


        public string Name { get; set; }


        public string FirstName { get; set; }

        [Range(16, 80)]
        public int Age { get; set; }

        [JsonIgnore]
        public int AfdelingId { get; set; }
        public Afdeling Afdeling { get; set; }


    }
}
