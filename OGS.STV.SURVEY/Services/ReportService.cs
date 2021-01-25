using AutoMapper;
using Microsoft.Extensions.Logging;
using OGS.STV.SURVEY.Data;
using OGS.STV.SURVEY.Data.Entities;
using OGS.STV.SURVEY.ViewModels;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Services
{
    public class ReportService : IReportService
    {
        private readonly ISurveyRepository _repository;
        private readonly ILogger<ReportService> _logger;
        private readonly IMapper _mapper;

        public ReportService(ISurveyRepository repository, ILogger<ReportService> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public bool InsertReport(int contractId)
        {
            Contract contract = _repository.GetContract(contractId);
            Report report = GenerateReport(contract);

            _repository.AddEntity(report);
            
            var result = _repository.SaveAll();

            return result;
        }  
        private static Report GenerateReport(Contract contract)
        {
            SurveyUser surveyUser = contract.SurveyUser;
            Report report = new Report()
            {
                CardNO = surveyUser.CardNO,
                City = surveyUser.City.Name,
                ContractId = contract.Id,
                CreateDate = DateTime.Now.ToShortDateString(),
                Email = surveyUser.Email,
                FullName = surveyUser.FullName,
                InsuranceList = GenerateInsuranceList(contract.ContractInsurances),
                MailSend = contract.MailSendStatus.ToString(),
                Phone = surveyUser.Phone,
                TCNO = surveyUser.TCNO
    };
            return report;
        }
        private static string GenerateInsuranceList(List<ContractInsurance> list)
        {
            string result = "";
            foreach (var item in list)
            {
                result += item.Insurance.Name + ", ";
            }
            
            return result[0..^2];
        }

        public List<ReportViewModel> GetReportViewModels()
        {
            List<ReportViewModel> models = new List<ReportViewModel>();
            try
            {
                List<Report> reports = _repository.GetReports();

                models = _mapper.Map<List<ReportViewModel>>(reports);
            }
            catch (Exception)
            {
                _logger.LogWarning("Could not get reports.");                
            }
            return models;
        }
    }
}