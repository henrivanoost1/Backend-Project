using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistrationAPI.Models;
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
        public KAJController()
        {

        }

        [HttpGet]
        [Route("/afdelingen")]
        public List<Afdeling> GetAfdelingen()
        {
            return null;
        }

        [HttpGet]
        [Route("/gewest")]
        public List<Gewest> GetGewesten()
        {
            return null;
        }

        [HttpGet]
        [Route("/leden")]
        public ActionResult<List<VaccinationRegistration>> GetRegistrations(string date = "")
        {
            return Ok();
        }

        [HttpPost]
        [Route("/registration")]
        public ActionResult<VaccinationRegistration> AddRegistration(VaccinationRegistration registration)
        {

            return null;
        }

    }
}
