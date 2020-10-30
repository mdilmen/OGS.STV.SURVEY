using Microsoft.AspNetCore.Mvc;
using OGS.STV.SURVEY.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Controllers
{
    public class ValidationTcNoController : Controller
    {
        
        private readonly ValidationHttpClient _validationHttpClient;

        public ValidationTcNoController(ValidationHttpClient validationHttpClient)
        {        
            _validationHttpClient = validationHttpClient;
        }
        [HttpPost]
        public JsonResult IsMember(string tcno)
        {
            var msg = string.Format("{0} bir Şişli Terakki üyesine ait değil.", tcno);
            try
            {
                bool isMember = _validationHttpClient.Validate(tcno).Result;

                if (!isMember)
                    return Json(msg);
                else
                    return Json(true);
            }
            catch (Exception)
            {
                //return Json(true);
                return Json(msg);
            }
        }


    }
}
