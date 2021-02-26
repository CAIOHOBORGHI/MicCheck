using MicCheck.API.Requests;
using MicCheck.Shared.Responses;
using MicCheck.Shared.Models;
using MicCheck.Shared.Responses;
using MicCheck.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MicCheck.API.Controllers
{
    public class BandController : Controller
    {
        private IBandService _bandService;
        private ILogger _logger;
        private BaseResponse _baseResponse;
        public BandController(IBandService bandService, ILogger logger)
        {
            _baseResponse = new BaseResponse();
            _bandService = bandService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult AddFan([FromBody]AddFanToBandRequest request)
        {
            if (!ModelState.IsValid)
            {
                _baseResponse.Message = "Error trying add a Fan! Missing required properties!";
                _baseResponse.Success = false;
                return Ok(_baseResponse);
            }

            _bandService.AddFanRelationship(request.FanId, request.BandId, request.Liked);
            _baseResponse.Message = "Successfully added new fan!";
            return Ok(_baseResponse);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            BaseDataResponse<List<BandModel>> response = new BaseDataResponse<List<BandModel>>();
            List<BandModel> bands = _bandService.GetAll();
            if (bands.Count == 0)
            {
                response.Message = "Bands not found!";
                response.Success = false;
            }
            else
            {
                response.Message = "Bands loaded successfully!";
            }
            return Ok(response);
        }

    }
}
