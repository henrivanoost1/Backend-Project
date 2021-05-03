using System;
using System.Collections.Generic;
using AutoMapper;
using Backend_Project.Models;

namespace Backend_Project.DTO
{
    public class RegioverantwoordelijkeDTO
    {
        public int RegioverantwoordelijkeId { get; set; }


        public string Name { get; set; }


        public string FirstName { get; set; }


        public int Age { get; set; }


        public string Email { get; set; }

        public int GewestId { get; set; }

    }
}
