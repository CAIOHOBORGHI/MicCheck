using MicCheck.Core.Models;
using MicCheck.Core.Repositories.Interfaces;
using MicCheck.Core.Responses;
using MicCheck.Core.Services.Interfaces;
using MicCheck.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Core.Services
{
    public class BandService : IBandService
    {
        private IBandRepository _bandRepository;
        public BandService(IBandRepository bandRepository)
        {
            _bandRepository = bandRepository;
        }

        public BaseResponse<List<BandModel>> GetAll()
        {
            BaseResponse <List<BandModel>> response = new BaseResponse<List<BandModel>>();
            List<Band> bandEntities = _bandRepository.GetAll();
            List<BandModel> bandModels = new List<BandModel>();
            if (bandEntities.Count > 0)
            {
                // If database has any band, we'll convert it to model and hide sensitive data
                bandModels = 
                    bandEntities
                        .Select(s => new BandModel
                        {
                            BandId = s.Id,
                            Name = s.Name,
                            FansCount = s.FansRelationships.Count(fr => fr.Liked),
                            GenreTags = s.GenreTags?.Select(s => s.Genre.Name).ToList(),
                            HomeTown = s.HomeTown
                        }).ToList();

                response.Data = bandModels;
                response.Message = "Loaded bands sucessfully";
            }
            else
            {
                response.Success = false;
                response.Message = "Band list is null!";
            }

            return response;
        }
    }
}
