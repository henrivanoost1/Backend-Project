using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Backend_Project.Models;
using Backend_Project.DataContext;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Globalization;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace Backend_Project.Controllers
{
    [ApiController]
    [Route("api")]
    public class KAJController : ControllerBase
    {
        private KAJContext _context;
        public KAJController(KAJContext context)
        {
            _context = context;

        }

        [HttpGet]
        [Route("afdelingen")]
        public async Task<List<Afdeling>> GetAfdelingen()
        {
            return await _context.Afdelingen.ToListAsync();
        }

        [HttpGet]
        [Route("gewesten")]
        public async Task<List<Gewest>> GetGewesten()
        {
            return await _context.Gewesten.ToListAsync();
        }

        [HttpGet]
        [Route("leden")]
        public async Task<List<Lid>> GetLeden()
        {
            return await _context.Leden.ToListAsync();
        }

        [HttpGet]
        [Route("regioverantwoordelijken")]
        public async Task<List<Regioverantwoordelijke>> GetRegioverantwoordelijken()
        {
            return await _context.Regioverantwoordelijken.ToListAsync();
        }



        // [HttpGet]
        // [Route("/leden")]
        // public ActionResult<List<VaccinationRegistration>> GetRegistrations(string date = "")
        // {
        //     return Ok();
        // }

        [HttpPost]
        [Route("lid")]
        public async Task<ActionResult<Lid>> AddLid(Lid lid)
        {

            try
            {
                await _context.Leden.AddAsync(lid);
                await _context.SaveChangeAsync();
                return lid;

            }
            catch (Exception ex)
            {

                return new StatusCodeResult(500);
            }
        }

    }
}
