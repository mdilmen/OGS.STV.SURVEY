using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Services
{
    public interface IReportService
    {
        bool InsertReport(int contractId);
    }
}
