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
        [Route("/afdelingen")]
        public List<Afdeling> GetAfdelingen()
        {
            return _context;
        }

        [HttpGet]
        [Route("/gewest")]
        public List<Gewest> GetGewesten()
        {
            return null;
        }

        // [HttpGet]
        // [Route("/leden")]
        // public ActionResult<List<VaccinationRegistration>> GetRegistrations(string date = "")
        // {
        //     return Ok();
        // }

        // [HttpPost]
        // [Route("/registration")]
        // public ActionResult<VaccinationRegistration> AddRegistration(VaccinationRegistration registration)
        // {

        //     return null;
        // }

    }
}
