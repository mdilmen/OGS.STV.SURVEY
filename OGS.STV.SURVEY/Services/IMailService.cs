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
    public interface IMailService
    {
        Task<bool> SendMailASync(CancellationToken cancellationToken, MailRequestModel mailRequestModel, Contract contract);
    }
}
