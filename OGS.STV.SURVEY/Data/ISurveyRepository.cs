using OGS.STV.SURVEY.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Data
{
    public interface ISurveyRepository
    {
        bool SaveAll();
        void AddEntity(object model);
        List<City> GetAllCities();
        City GetCity(int id);
        List<Insurance> GetAllInsurances();
        List<Insurance> GetInsurances(List<int> insuranceIdList);
        Contract GetContract(int id);
        List<Report> GetReports();

    }
}
