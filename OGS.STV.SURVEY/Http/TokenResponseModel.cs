using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Http
{
    public class TokenResponseModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Error
        {
            public string Code { get; set; }
            public string Message { get; set; }
        }


        public string ServiceTicket { get; set; }
        public bool Success { get; set; }
        public List<Error> Errors { get; set; }
        public string DetailedMessage { get; set; }
        public object TransactionId { get; set; }


    }
}


