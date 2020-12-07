using Microsoft.CodeAnalysis.Diagnostics;
using OGS.STV.SURVEY.Data.Entities;
using OGS.STV.SURVEY.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Services
{
    public class MailService : IMailService
    {
        private readonly MailHttpClient _client;

        public MailService(MailHttpClient client)
        {
            _client = client;
        }
        public Task<bool> SendMail(CancellationToken cancellationToken, MailRequestModel mailRequestModel, Contract contract)
        {
            var token = _client.GetToken().GetAwaiter().GetResult();
            var result = _client.PostSendMail(cancellationToken, token, CreateMailRequest(contract));
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
                + contract.SurveyUser.TCNO + "</br>"
                + contract.SurveyUser.BirthDate.ToShortDateString() + "</br>"
                + contract.SurveyUser.City.Name + "</br>"
                + contract.SurveyUser.Email + "</br>"
                + contract.SurveyUser.Phone + "</br>"
                + subjectHtml + "</br>"
                + "</body></html>";
            MailRequestModel mailRequestModel = new MailRequestModel()
            {
                FromName = "Oyak Yatırım",

                FromAddress = "oyakyatirim@e.oyakyatirim.com.tr",

                ReplyAddress = "bilgi@oyakyatirim.com.tr",

                Subject = subject,

                HtmlBody = body,

                Charset = "utf-8",

                ToName = "Derya Uçunoğlu",

                ToEmailAddress = "mustafa.dilmen@oyakyatirim.com.tr",
                //ToEmailAddress = "derya.ucunoglu@oyakgrupsigorta.com",
                //ToEmailAddress = "sisliterakki@oyakgrupsigorta.com",                

                PostType = "Anket Maili",

                KeyId = "",

                CustomParams = ""
            };
            return mailRequestModel;
        }
    }
}
