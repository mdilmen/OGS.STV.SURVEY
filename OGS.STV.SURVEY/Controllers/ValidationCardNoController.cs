using Microsoft.AspNetCore.Mvc;
using OGS.STV.SURVEY.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Controllers
{
    public class ValidationCardNoController
    {
        private readonly ValidationHttpClient _validationHttpClient;
        public ValidationCardNoController(ValidationHttpClient validationHttpClient)
        {
            _validationHttpClient = validationHttpClient;
        }
        [HttpPost]
        public JsonResult IsValidCardNo(string cardNo)
        {
            var msg = string.Format("{0} bir Şişli Terakki üyesine ait değil.", cardNo);
            try
            {
                bool isValid = _validationHttpClient.Validate(cardNo).Result;

                if (!isValid)
                    return new JsonResult(msg);
                else
                    return new JsonResult(true);
            }
            catch (Exception)
            {
                //return Json(true);
                return new JsonResult(msg);
            }
        }
    }
}
