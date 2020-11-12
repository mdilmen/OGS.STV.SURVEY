using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Http
{
    public class MailRequestModel
    {
        public string FromName { get; set; }
        public string FromAddress { get; set; }
        public string ReplyAddress { get; set; }
        public string Subject { get; set; }
        public string HtmlBody { get; set; }
        public string Charset { get; set; }
        public string ToName { get; set; }
        public string ToEmailAddress { get; set; }
        public string PostType { get; set; }
        public string KeyId { get; set; }
        public string CustomParams { get; set; }
    }
}
