using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend_Project.DataContext;
using Backend_Project.Models;

namespace Backend_Project.Repositories
{
    public interface IAfdelingRepository
    {
        Task<Afdeling> AddAfdeling(Afdeling afdeling);
        Task<List<Afdeling>> GetAfdelingen();
        Task<Afdeling> GetAfdeling(int afdelingId);

    }
    public class AfdelingRepository : IAfdelingRepository
    {
        private IKAJContext _context;
        public AfdelingRepository(IKAJContext context)
        {
            _context = context;
        }

        public async Task<List<Afdeling>> GetAfdelingen()
        {
            return await _context.Afdelingen.Include(s => s.RegioverantwoordelijkeAfdelingen).Include(s => s.Gewest).ToListAsync();
        }

        public async Task<Afdeling> AddAfdeling(Afdeling afdeling)
        {
            await _context.Afdelingen.AddAsync(afdeling);
            await _context.SaveChangesAsync();
            return afdeling;
        }

        public async Task<Afdeling> GetAfdeling(int afdelingId)
        {
            // return await _context.Afdelingen.Where(s => s.AfdelingId == afdelingId).Include(s => s.Gewest).Include(s => s.Leden).Include(s => s.RegioverantwoordelijkeAfdelingen).ThenInclude(s => s.Regioverantwoordelijke).SingleOrDefaultAsync();
            return await _context.Afdelingen.Where(s => s.AfdelingId == afdelingId).Include(s => s.Gewest).Include(s => s.Leden).Include(s => s.RegioverantwoordelijkeAfdelingen).SingleOrDefaultAsync();

        }

    }
}
