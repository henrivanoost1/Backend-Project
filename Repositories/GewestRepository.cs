using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend_Project.DataContext;
using Backend_Project.Models;
namespace Backend_Project.Repositories
{
    public interface IGewestRepository
    {
        Task<List<Gewest>> GetGewesten();
        Task<Gewest> GetGewest(int gewestId);

    }
    public class GewestRepository : IGewestRepository
    {
        private IKAJContext _context;
        public GewestRepository(IKAJContext context)
        {
            _context = context;
        }

        public async Task<List<Gewest>> GetGewesten()
        {
            try
            {
                return await _context.Gewesten.ToListAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        public async Task<Gewest> GetGewest(int gewestId)
        {
            return await _context.Gewesten.Where(s => s.GewestId == gewestId).SingleOrDefaultAsync();
        }


    }
}
