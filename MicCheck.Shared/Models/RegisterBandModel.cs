using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.Shared.Models
{
    public class RegisterBandModel : UserModel
    {
        public override string Role => "Band";

        [Required(ErrorMessage = "Please insert a profile description")]
        [MaxLength(120, ErrorMessage = "Descripition should not exceed 120 characters limit!")]
        [MinLength(10, ErrorMessage = "Description requires at leat 10 characters!")]
        public string Description { get; set; }

        public string PicturePath { get; set; }
        public string PresentationAudioPath { get; set; }
        public string VideoClipPath { get; set; }
    }
}
