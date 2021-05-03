using System;
using System.Collections.Generic;
using AutoMapper;
using Backend_Project.Models;

namespace Backend_Project.DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Lid, LidDTO>();
            CreateMap<RegioverantwoordelijkeDTO, Regioverantwoordelijke>();
            CreateMap<GewestDTO, Gewest>();

        }

    }
}
