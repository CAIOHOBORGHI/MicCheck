using MicCheck.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Requests
{
    public class RegisterBandRequest : UserModel
    {
        public override string Role => "Band";

        [Required]
        [MaxLength(120, ErrorMessage = "Descripition should not exceed 120 characters limit!")]
        public string Description { get; set; }

        public string PicturePath { get; set; }
        public string PresentationAudioPath { get; set; }
        public string VideoClipPath { get; set; }
    }
}
