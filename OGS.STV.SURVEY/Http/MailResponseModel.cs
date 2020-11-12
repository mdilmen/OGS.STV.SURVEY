using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Http
{
    public class MailResponseModel
    {
        public string PostId { get; set; }
        public bool Success { get; set; }
        public List<object> Errors { get; set; }
        public string DetailedMessage { get; set; }
        public object TransactionId { get; set; }
    }
}
