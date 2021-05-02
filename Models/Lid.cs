using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Backend_Project.Models
{
    public class Lid
    {
        public int LidId { get; set; }


        public string Name { get; set; }


        public string FirstName { get; set; }

        public int Age { get; set; }


        public int AfdelingId { get; set; }
        public Afdeling Afdeling { get; set; }


    }
}
