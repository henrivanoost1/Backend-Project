using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend_Project.DataContext;
using Backend_Project.Models;

namespace Backend_Project.Repositories
{
    public interface ILidRepository
    {
        Task<List<Lid>> GetLeden();
        Task<Lid> GetLid(int lidId);
        Task<Lid> AddLid(Lid lid);


    }
    public class LidRepository : ILidRepository
    {
        private IKAJContext _context;
        public LidRepository(IKAJContext context)
        {
            _context = context;
        }

        public async Task<List<Lid>> GetLeden()
        {
            try
            {
                return await _context.Leden.ToListAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<Lid> AddLid(Lid lid)
        {
            await _context.Leden.AddAsync(lid);
            await _context.SaveChangesAsync();
            return lid;
        }


        public async Task<Lid> GetLid(int lidId)
        {
            return await _context.Leden.Where(s => s.LidId == lidId).SingleOrDefaultAsync();
        }

    }
}
