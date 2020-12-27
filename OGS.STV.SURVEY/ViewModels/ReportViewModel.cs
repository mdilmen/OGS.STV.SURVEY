using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.ViewModels
{
    public class ReportViewModel
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string CreateDate { get; set; }
        public string FullName { get; set; }
        public string CardNO { get; set; }
        public string TcNO { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string InsuranceList { get; set; }
        public string MailSend { get; set; }
    }
}
