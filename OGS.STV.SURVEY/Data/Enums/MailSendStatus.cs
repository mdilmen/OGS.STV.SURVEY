using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Data.Enums
{
    public enum MailSendStatus
    {
        [Description("Gönderildi")]
        MailSend,
        [Description("Gönderilmedi")]
        MailNotSend
    }
}
