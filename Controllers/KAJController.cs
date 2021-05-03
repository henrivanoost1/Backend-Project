using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Backend_Project.Models;
using Backend_Project.DTO;
using Backend_Project.Services;
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
        private readonly IKAJService _kajService;
        private readonly ILogger<KAJController> _logger;
        public KAJController(ILogger<KAJController> logger, IKAJService kajService)
        {
            _logger = logger;
            _kajService = kajService;

        }


        [HttpGet]
        [Route("gewesten")]
        public async Task<ActionResult<List<Gewest>>> GetGewesten()
        {
            try
            {
                return new OkObjectResult(await _kajService.GetGewesten());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        [Route("gewest/{GewestId}")]
        public async Task<ActionResult<List<Gewest>>> GetGewest(int gewestId)
        {
            try
            {
                return new OkObjectResult(await _kajService.GetGewest(gewestId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("lidjes")]
        public async Task<ActionResult<Lid>> AddLid(Lid lid)
        {
            try
            {
                return new OkObjectResult(await _kajService.AddLid(lid));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("leden")]
        public async Task<ActionResult<List<LidDTO>>> GetLeden()
        {
            try
            {
                return new OkObjectResult(await _kajService.GetLeden());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        [Route("regioverantwoordelijken")]
        public async Task<ActionResult<List<Regioverantwoordelijke>>> GetRegioverantwoordelijken()
        {
            try
            {
                return new OkObjectResult(await _kajService.GetRegioverantwoordelijken());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
