using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string ApiRoute { get; set; }
        public string ApiStatus { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
