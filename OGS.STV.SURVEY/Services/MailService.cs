using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OGS.STV.SURVEY.Data.Entities;
using OGS.STV.SURVEY.Http;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Services
{
    public class MailService : IMailService
    {
        private readonly MailHttpClient _client;
        private readonly IConfiguration _config;
        private readonly ILogger<MailService> _logger;

        public MailService(MailHttpClient client, IConfiguration config,ILogger<MailService> logger)
        {
            _client = client;
            _config = config;
            _logger = logger;
        }
        public async Task<bool> SendMailASync(CancellationToken cancellationToken, MailRequestModel mailRequestModel, Contract contract)
        {
            bool result = false;
            try
            {
                var token = await _client.GetToken(cancellationToken);                
                result = await _client.PostSendMail(cancellationToken, token, CreateMailRequest(contract));
            }

            catch (Exception ex)
            {
                _logger.LogWarning($"Mail could not be send : {mailRequestModel.FromName} - exception : {ex.Message}");             
            }
            return result;
        }

        public MailRequestModel CreateMailRequest(Contract contract)
        {
            //Subject 
            string subject = "";
            subject = contract.SurveyUser.FullName + " - ";
            foreach (var item in contract.ContractInsurances)
            {
                subject += item.Insurance.Name + ", ";
            }
            subject = subject[0..^2];

            //SubjectHtml
            string subjectHtml = "";
            subjectHtml = "<ul>";
            foreach (var item in contract.ContractInsurances)
            {
                subjectHtml += "<li>" + item.Insurance.Name + "</li>";
            }
            subjectHtml += "</ul>";
            // HtmlBody
            string body = "";
            body = "<html><head></head><body><h4>"
                + contract.SurveyUser.FullName + "</h4>"
                + contract.SurveyUser.CardNO + "</br>"
                + contract.SurveyUser.TCNO + "</br>"
                + contract.SurveyUser.BirthDate.ToShortDateString() + "</br>"
                + contract.SurveyUser.City.Name + "</br>"
                + contract.SurveyUser.Email + "</br>"
                + contract.SurveyUser.Phone + "</br>"
                + subjectHtml + "</br>"
                + "</body></html>";
            MailRequestModel mailRequestModel = new MailRequestModel()
            {
                FromName = _config["ContactString:FromName"],

                FromAddress = _config["ContactString:FromAddress"],

                ReplyAddress = _config["ContactString:ReplyAddress"],

                Subject = subject,

                HtmlBody = body,

                Charset = _config["ContactString:Charset"],

                ToName = _config["ContactString:ToName"],

                ToEmailAddress = _config["ContactString:ToEmailAddress"],

                PostType = _config["ContactString:PostType"],

                KeyId = _config["ContactString:KeyId"],

                CustomParams = _config["ContactString:CustomParams"],
            };
            return mailRequestModel;
        }
    }
}
