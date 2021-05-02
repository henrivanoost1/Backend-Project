using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend_Project.DataContext;
using Backend_Project.Models;

namespace Backend_Project.Repositories
{
    public interface IRegioverantwoordelijkeRepository
    {
        Task<Regioverantwoordelijke> AddRegioverantwoordelijke(Regioverantwoordelijke regioverantwoordelijke);
        Task<List<Regioverantwoordelijke>> GetRegioverantwoordelijken();
        Task<Regioverantwoordelijke> GetRegioverantwoordelijke(int regioverantwoordelijkeId);

    }
    public class RegioverantwoordelijkeRepository : IRegioverantwoordelijkeRepository
    {
        private IKAJContext _context;
        public RegioverantwoordelijkeRepository(IKAJContext context)
        {
            _context = context;
        }

        public async Task<List<Regioverantwoordelijke>> GetRegioverantwoordelijken()
        {
            // return await _context.Regioverantwoordelijken.Include(s => s.RegioverantwoordelijkeAfdelingen).Include(s => s.Gewest).ToListAsync();
            return await _context.Regioverantwoordelijken.Include(s => s.Gewest).ToListAsync();

        }

        public async Task<Regioverantwoordelijke> AddRegioverantwoordelijke(Regioverantwoordelijke regioverantwoordelijke)
        {
            await _context.Regioverantwoordelijken.AddAsync(regioverantwoordelijke);
            await _context.SaveChangesAsync();
            return regioverantwoordelijke;
        }

        public async Task<Regioverantwoordelijke> GetRegioverantwoordelijke(int regioverantwoorelijkeId)
        {
            return await _context.Regioverantwoordelijken.Where(s => s.RegioverantwoordelijkeId == regioverantwoorelijkeId).Include(s => s.Gewest).SingleOrDefaultAsync();
        }

    }
}
