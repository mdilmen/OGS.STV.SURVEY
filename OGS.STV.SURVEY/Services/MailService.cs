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
        public Task<bool> SendMail(CancellationToken cancellationToken, MailRequestModel mailRequestModel)
        {
            var token = _client.GetToken().GetAwaiter().GetResult();
            var result = _client.PostSendMail(cancellationToken, token, mailRequestModel);
            return result;
        }
    }
}
