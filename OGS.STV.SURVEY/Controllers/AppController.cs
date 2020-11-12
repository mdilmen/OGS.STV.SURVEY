using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using OGS.STV.SURVEY.Data;
using OGS.STV.SURVEY.Data.Entities;
using OGS.STV.SURVEY.Data.Enums;
using OGS.STV.SURVEY.Services;
using OGS.STV.SURVEY.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Controllers
{
    public class AppController : Controller
    {
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private readonly ISurveyRepository _repository;
        private readonly IMailService _mailService;

        public AppController(ISurveyRepository repository, IMailService mailService)
        {
            _repository = repository;
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Contract", "App");
        }

        [HttpGet("Contract")]
        public IActionResult Contract()
        {
            var listCities = new List<SelectListItem>();
            var cities = _repository.GetAllCities();
            foreach (var city in cities.Where(c => c.Id != 9).OrderBy(c => c.CityOrder))
            {
                var item = new SelectListItem { Text = city.Name, Value = city.Id.ToString() };
                listCities.Add(item);
            }
            ViewBag.Cities = listCities;

            var listInsurances = new List<SelectListItem>();
            var insurances = _repository.GetAllInsurances();
            foreach (var insurance in insurances)
            {
                var item = new SelectListItem { Text = insurance.Name, Value = insurance.Id.ToString() };
                listInsurances.Add(item);
            }
            ViewBag.Insurances = listInsurances;


            ViewBag.Title = "Bilgiler";
            return View();
        }
        [HttpPost("Contract")]
        public IActionResult Contract(ContractViewModel model)
        {
            if (ModelState.IsValid)
            {
                SurveyUser surveyUser = new SurveyUser()
                {
                    TCNO = model.TCNO,
                    Email = model.Email,
                    FullName = model.FullName,
                    BirthDate = model.BirthDate,
                    Phone = model.PhoneNumber,
                    City = _repository.GetCity((int)model.CityId),
                };
                Contract contract = new Contract()
                {
                    SurveyUser = surveyUser,
                    MailSendStatus = MailSendStatus.MailNotSend
                };
                List<Insurance> modelInsuranceList = _repository.GetInsurances(model.Insurances);
                foreach (var item in modelInsuranceList)
                {
                    ContractInsurance contractInsurance = new ContractInsurance()
                    {
                        Contract = contract,
                        Insurance = item
                    };
                    contract.ContractInsurances.Add(contractInsurance);
                }
                _repository.AddEntity(contract);

                _repository.SaveAll();
                _mailService.SendMail(_cancellationTokenSource.Token, new Http.MailRequestModel());
                return RedirectToAction("Success", "App");
            }
            return View();
        }
        [HttpGet("Success")]
        public IActionResult Success()
        {
            ViewBag.Title = "Success";
            return View();
        }
    }
}
