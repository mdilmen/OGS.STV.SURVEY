using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OGS.STV.SURVEY.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Controllers
{
    public class AppController : Controller
    {
        private readonly ISurveyRepository _repository;

        public AppController(ISurveyRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var listCities = new List<SelectListItem>();
            var cities = _repository.GetAllCities();
            foreach (var city in cities.Where(c => c.Id != 9).OrderBy(c => c.CityOrder))
            {
                var item = new SelectListItem { Text = city.Name, Value = city.Id.ToString() };
                listCities.Add(item);
            }
            ViewBag.Cities = listCities;
            ViewBag.Title = "Teklif için Talep Edilen Bilgiler";
            return View();
        }
    }
}
