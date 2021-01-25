using Microsoft.Extensions.Logging;
using OGS.STV.SURVEY.Data.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Data
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly SurveyDbContext _context;
        private readonly ILogger<SurveyRepository> _logger;

        public SurveyRepository(SurveyDbContext context, ILogger<SurveyRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
        public void AddEntity(object model)
        {
            _context.Add(model);
        }

        public List<City> GetAllCities()
        {
            return _context.Cities.OrderBy(c => c.CityOrder).ToList();
        }

        public List<Insurance> GetAllInsurances()
        {
            return _context.Insurances.OrderBy(i => i.InsuranceOrder).ToList();
        }

        public City GetCity(int id)
        {
            return _context.Cities.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Insurance> GetInsurances(List<int> insuranceIdList)
        {
            return _context.Insurances.Where(i => insuranceIdList.Contains(i.Id)).OrderBy(i=> i.InsuranceOrder).ToList();
        }

        public Contract GetContract(int id)
        {
            return _context.Contracts.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Report> GetReports()
        {
            _logger.LogInformation("Some one is calling the repository to get the Reports..");
            return _context.Reports.OrderByDescending(r => r.Id).ToList();
        }
    }
}
