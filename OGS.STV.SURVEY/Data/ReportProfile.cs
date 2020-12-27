using AutoMapper;
using OGS.STV.SURVEY.Data.Entities;
using OGS.STV.SURVEY.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Data
{
    public class ReportProfile :Profile
    {
        public ReportProfile()
        {
            this.CreateMap<Report, ReportViewModel>();
        }
    }
}
