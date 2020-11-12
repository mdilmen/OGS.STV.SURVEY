using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Controllers
{
    public class ValidationController : Controller
    {
        [HttpPost]
        public JsonResult IsValidDateOfBirth(string birthdate)
        {
            var dtMax = new DateTime(DateTime.Now.Year, 1, 1);
            var min = DateTime.Now.AddYears(-18);
            var max = dtMax.AddYears(-75);
            var msg = string.Format("Tekliflerimiz 18-75 yaş aralığı için verilmektedir.64 yaş üstü kişiler için genel müdürlük tarafından sizler ile iletişimde olunarak farklı teklifler iletilecektir.Talebinize ilişkin olarak info@oyakgrupsigorta.com adresine dönüş yapmanızı rica ederiz.En kısa sürede talebinize ilişkin olarak size dönüş sağlanacaktır.");
            var msg18 = string.Format("Üye 18 yaşından küçük olamaz.");
            try
            {
                var date = DateTime.Parse(birthdate);
                if (date < max)
                    return Json(msg);
                else if (date > min)
                    return Json(msg18);
                else
                    return Json(true);
            }
            catch (Exception)
            {
                return Json(msg);
            }
        }
    }
}
