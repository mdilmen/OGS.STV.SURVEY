﻿using OGS.STV.SURVEY.Http;
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
        Task<bool> SendMail(CancellationToken cancellationToken, MailRequestModel mailRequestModel);
    }
}