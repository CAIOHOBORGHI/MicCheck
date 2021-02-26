using MicCheck.Shared.Models;
using MicCheck.Core.Repositories.Interfaces;
using MicCheck.Shared.Responses;
using MicCheck.API.Services.Interfaces;
using MicCheck.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicCheck.Data.Repositories.Interfaces;
using MicCheck.API.Requests;

namespace MicCheck.API.Services
{
    // In this service layer, we add another layer of validations and logical operations
    public class BandService : IBandService
    {
        private IBandRepository _bandRepository;
        private IFanRepository _fanRepository;
        private IFanBandRepository _fanBandRepository;
        private ISecurityService _securityService;

        private BaseResponse _response = new BaseResponse();
        public BandService(IBandRepository bandRepository, IFanRepository fanRepository, IFanBandRepository fanBandRepository, ISecurityService securityService)
        {
            _bandRepository = bandRepository;
            _fanBandRepository = fanBandRepository;
            _fanRepository = fanRepository;
            _securityService = securityService;
        }

        public BaseResponse AddFanRelationship(int bandId, int fanId, bool liked)
        {
            Band bandEntity = _bandRepository.Get(band => band.Id == bandId);
            if (bandEntity == null)
                return _response.Error("Band was not found!");

            Fan fanEntity = _fanRepository.Get(fan => fan.Id == fanId);
            if (fanEntity == null)
                return _response.Error("Fan was not found!");

            FanBandRelationship newRelationship = new FanBandRelationship { BandId = bandId, FanId = fanId, Liked = liked, ChoiceDate = DateTime.Now };
            _fanBandRepository.Insert(newRelationship);
            _response.Message = "Fan added with success!";
            return _response;
        }


        public List<BandModel> GetByGenre(string genre)
        {
            //TODO: Add includes
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
                    new BandModel
                    {
                        BandId = entity.Id,
                        Name = entity.Name,
                        GenreTags = entity.GenreTags.Select(s => s.Genre.Name).ToList()
                    })
                .ToList();

            return models;
        }

        public List<BandModel> GetAll()
        {
            //TODO: Add includes
            List<Band> bandEntities = _bandRepository.GetAll();
            List<BandModel> bandModels = new List<BandModel>();

            if (bandEntities.Count > 0)
            {
                // If database has any band, we'll convert it to model to hide sensitive data
                bandModels =
                    bandEntities
                        .Select(s => new BandModel
                        {
                            BandId = s.Id,
                            Name = s.Name,
                            FansCount = s.FansRelationships.Count(fr => fr.Liked),
                            GenreTags = s.GenreTags?.Select(s => s.Genre.Name).ToList(),
                            Hometown = s.Hometown
                        }).ToList();
            }

            return bandModels;
        }

        public BaseDataResponse<BandModel> RegisterBand(RegisterBandModel model)
        {
            BaseDataResponse<BandModel> response = new BaseDataResponse<BandModel>();

            // Service layer validations 
            #region Validations
            if (string.IsNullOrWhiteSpace(model.Name))
            {
                response.Error("Band name can't be empty!");
                return response;
            }

            if (string.IsNullOrWhiteSpace(model.Password))
            {
                response.Error("Password can't be empty!");
                return response;
            }
            #endregion

            string hashedPassword = _securityService.HashPassword(model.Password);

            Band entity = new Band { 
                Name = model.Name, 
                Email = model.Email, 
                Description = model.Description, 
                HashedPassword = hashedPassword,
                Hometown = model.Hometown, 
                PicturePath = model.PicturePath, 
                PresentationAudioPath = model.PresentationAudioPath, 
                VideoClipPath = model.VideoClipPath 
            };
            _bandRepository.Insert(entity);

            BandModel bandModel = new BandModel { BandId = entity.Id, Name = entity.Name, Hometown = entity.Hometown };
            response.Ok("Band inserted successfully!");
            response.Data = bandModel;
            return response;
        }

    }
}
