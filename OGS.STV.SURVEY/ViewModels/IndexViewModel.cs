using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.ViewModels
{
    public class IndexViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        [MinLength(11, ErrorMessage = "en az 11 hane olmalı")]
        [Remote(action: "IsMember",controller: "ValidationTcNo",HttpMethod ="POST", ErrorMessage = "Tc No is not valid.")]        
        public string TCNO { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        [MinLength(5, ErrorMessage = "en az 5 hane olmalı")]
        public string FullName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        [Remote("IsValidDateOfBirth", "Validation", HttpMethod = "POST", ErrorMessage = "Please provide a valid date of birth.")]
        public DateTime BirthDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        public int CityId { get; set; }
    }
}
