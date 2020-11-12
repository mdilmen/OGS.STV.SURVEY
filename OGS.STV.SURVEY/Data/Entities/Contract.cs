using OGS.STV.SURVEY.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Data.Entities
{
    public class Contract
    {
        public Contract()
        {
            ContractInsurances = new List<ContractInsurance>();
        }
        public int Id { get; set; }
        public SurveyUser SurveyUser { get; set; }        
        public MailSendStatus MailSendStatus { get; set; }
        public List<ContractInsurance> ContractInsurances { get; set; }
    }
}
