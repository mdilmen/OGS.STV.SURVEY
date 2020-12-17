using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly IReportService _reportService;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AppController(ISurveyRepository repository, IMailService mailService,IReportService reportService, SignInManager<IdentityUser> signInManager)
        {
            _repository = repository;
            _mailService = mailService;
            _reportService = reportService;
            _signInManager = signInManager;
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
        public async Task<IActionResult> Contract(ContractViewModel model)
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
                    CardNO = model.CardNo
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
                
                bool mailSend = await _mailService.SendMailASync(_cancellationTokenSource.Token, new Http.MailRequestModel(), contract);
                contract.MailSendStatus = mailSend ? MailSendStatus.MailSend : MailSendStatus.MailNotSend;

                _repository.AddEntity(contract);
                
                _repository.SaveAll();

                _reportService.InsertReport(contract.Id);

                return RedirectToAction("Success", "App");
            }
            return View();
        }
        [HttpGet("Success")]
        public IActionResult Success()
        {
            ViewBag.Title = "Sonuç";
            return View();
        }
        
        [HttpGet("Report")]
        public IActionResult Report()
        {
            if (_signInManager.IsSignedIn(User))
            {
                List<Report> reports = _repository.GetReports();
                ReportViewModel viewModel = MapReportToModel(reports);
                ViewBag.Title = "Success";
                return View(viewModel);
            }
            else 
            {
                return RedirectToAction("Login", "Account");
            }
        }
        private ReportViewModel MapReportToModel(List<Report> reports)
        {
            ReportViewModel viewModel = new ReportViewModel();
            foreach (var report in reports)
            {
                Info info = new Info()
                {
                    CardNO = report.CardNO,
                    City = report.City,
                    ContractId = report.ContractId,
                    CreateDate = report.CreateDate,
                    Email = report.Email,
                    FullName = report.FullName,
                    Id = report.Id,
                    InsuranceList = report.InsuranceList,
                    MailSend = report.MailSend,
                    Phone = report.Phone,
                    TcNO = report.TCNO
                };
                viewModel.Infos.Add(info);
            }
            return viewModel;
        }
    }
}
