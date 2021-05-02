using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Backend_Project.DataContext;
using Backend_Project.DTO;
using Backend_Project.Models;
using Backend_Project.Repositories;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Backend_Project.Services
{
    public interface ISneakerService
    {
        Task<Sneaker> GetSneaker(Guid sneakerId);
        Task<SneakerDTO> AddSneaker(SneakerDTO sneaker);
        Task<List<BrandDTO>> GetBrands();
        Task<List<OccasionDTO>> GetOccasions();
        Task<List<Sneaker>> GetSneakers();
        //  Task AddSneakerImage(Guid sneakerId, IFormFile file);
    }
    public class KAJService
    {
        public KAJService(IAfdelingRepository afdelingRepository, IGewestRepository gewestRepository, ILidRepository lidRepository, IRegioverantwoordelijkeRepository regioverantwoordelijkeRepository)
        {

        }

    }
}
