using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.ViewModels
{
    public class ContractViewModel
    {
        [RegularExpression(@"^(?=.{16,16}$)(?!.*?(.)\1{7})[0-9]+$", ErrorMessage = "Lütfen geçerli bir Kart No giriniz!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        [MinLength(16, ErrorMessage = "Kart No 16 hane olmalı")]
        [MaxLength(16, ErrorMessage = "Kart No 16 hane olmalı")]
        
        //[Remote(action: "IsValidCardNo",controller: "ValidationCardNo",HttpMethod ="POST", ErrorMessage = "Card No is not valid.")]        
        public string CardNo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        [RegularExpression(@"^(?=.{11,11}$)(?!.*?(.)\1{5})[0-9]+$", ErrorMessage = "Lütfen geçerli bir Tc No giriniz!")]
        [MinLength(11, ErrorMessage = "Tc No 11 hane olmalı")]
        [MaxLength(11, ErrorMessage = "Tc No 11 hane olmalı")]
        public string TCNO { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        [MinLength(5, ErrorMessage = "En az 5 karakter olmalı")]
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
        [Remote("IsValidDateOfBirth", "Validation", HttpMethod = "POST", ErrorMessage = "Lütfen geçerli bir doğum tarihi giriniz.")]
        public DateTime BirthDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        public int CityId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir!")]
        public List<int> Insurances { get; set; }
    }
}
