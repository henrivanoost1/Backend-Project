using System;
using System.Collections.Generic;
using AutoMapper;
using Backend_Project.Models;

namespace Backend_Project.DTO
{
    public class LidDTO
    {
        public int LidId { get; set; }


        public string Name { get; set; }


        public string FirstName { get; set; }

        public int Age { get; set; }


        public int AfdelingId { get; set; }

    }
}
