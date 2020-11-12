using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Data.Entities
{
    public class ContractInsurance
    {
        public int Id { get; set; }
        public Contract Contract { get; set; }
        public Insurance Insurance { get; set; }
    }
}
