using MicCheck.Core.Models;
using MicCheck.Core.Responses;
using MicCheck.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Controllers
{
    [Route("api/{controller}/{action}")]
    public class BandController : Controller
    {
        private IBandService _bandService;
        private ILogger _logger;

        public BandController(IBandService bandService, ILogger logger)
        {
            _bandService = bandService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                BaseResponse<List<BandModel>> bands = _bandService.GetAll(); 
                return Ok(bands);
            }
            catch(Exception e)
            {
                _logger.LogError($"Error trying to fetch bands\n{e.Message}\n{e.StackTrace}");
                return StatusCode(500);
            }
        }

    }
}
