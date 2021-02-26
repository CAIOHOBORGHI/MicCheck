using MicCheck.API.Models;
using MicCheck.Core.Repositories.Interfaces;
using MicCheck.API.Responses;
using MicCheck.API.Services.Interfaces;
using MicCheck.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicCheck.Data.Repositories.Interfaces;

namespace MicCheck.API.Services
{
    public class BandService : IBandService
    {
        private IBandRepository _bandRepository;
        private IFanRepository _fanRepository;
        private IFanBandRepository _fanBandRepository;

        public BandService(IBandRepository bandRepository, IFanRepository fanRepository, IFanBandRepository fanBandRepository)
        {
            _bandRepository = bandRepository;
            _fanBandRepository = fanBandRepository;
            _fanRepository = fanRepository;
        }

        public BaseResponse AddFanRelationship(int bandId, int fanId, bool liked)
        {
            BaseResponse response = new BaseResponse();
            Band bandEntity = _bandRepository.Get(band => band.Id == bandId);
            if (bandEntity == null)
                return response.Error("Band was not found!");

            Fan fanEntity = _fanRepository.Get(fan => fan.Id == fanId);
            if (fanEntity == null)
                return response.Error("Fan was not found!");

            FanBandRelationship newRelationship = new FanBandRelationship { BandId = bandId, FanId = fanId, Liked = liked, ChoiceDate = DateTime.Now };
            _fanBandRepository.Insert(newRelationship);
            response.Message = "Fan added with success!";
            return response;
        }

        public List<BandModel> GetByGenre(string genre)
        {
            List<Band> entities = _bandRepository.GetAll(
                band => 
                    band
                    .GenreTags
                    .Select(s => s.Genre.Name)
                    .Contains(genre)
           );

            List<BandModel> models = 
                entities?.
                Select(entity => 
                    new BandModel { 
                        BandId = entity.Id, 
                        Name = entity.Name, 
                        GenreTags = entity.GenreTags.Select(s => s.Genre.Name).ToList()
                    })
                .ToList();

            return models;
        }

        public List<BandModel> GetAll()
        {
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
            }

            return bandModels;
        }
    }
}
