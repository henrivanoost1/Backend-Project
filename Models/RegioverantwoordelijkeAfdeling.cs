using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Backend_Project.Models
{
    public class RegioverantwoordelijkeAfdeling
    {


        // public int RegioverantwoordelijkeAfdelingId { get; set; }
        [Key]
        public int RegioverantwoordelijkeId { get; set; }



        public int AfdelingId { get; set; }



    }
}
