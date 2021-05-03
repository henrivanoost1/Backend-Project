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
    public interface IKAJService
    {
        Task<Gewest> GetGewest(int gewestId);
        Task<GewestDTO> AddGewest(GewestDTO gewest);
        Task<List<Gewest>> GetGewesten();
        Task<List<LidDTO>> GetLeden();
        Task<List<Regioverantwoordelijke>> GetRegioverantwoordelijken();

    }
    public class KAJService
    {
        private IGewestRepository _gewestRepository;
        private ILidRepository _lidRepository;

        private IRegioverantwoordelijkeRepository _regioverantwoordelijkeRepository;

        private IMapper _mapper;
        public KAJService(IMapper mapper, IGewestRepository gewestRepository, ILidRepository lidRepository, IRegioverantwoordelijkeRepository regioverantwoordelijkeRepository)
        {
            _mapper = mapper;
            _gewestRepository = gewestRepository;
            _lidRepository = lidRepository;
            _regioverantwoordelijkeRepository = regioverantwoordelijkeRepository;

        }

        public async Task<List<Gewest>> GetGewesten()
        {
            return await _gewestRepository.GetGewesten();
        }

        public async Task<List<LidDTO>> GetLeden()
        {
            return _mapper.Map<List<LidDTO>>(await _lidRepository.GetLeden());
        }

        public async Task<List<Regioverantwoordelijke>> GetRegioverantwoordelijken()
        {
            return await _regioverantwoordelijkeRepository.GetRegioverantwoordelijken();
        }

        public async Task<Gewest> GetGewest(int gewestId)
        {
            try
            {
                return await _gewestRepository.GetGewest(gewestId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<GewestDTO> AddGewest(GewestDTO gewest)
        {
            await _gewestRepository.AddGewest(gewest);
            return gewest;
        }



    }
}
