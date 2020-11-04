using OGS.STV.SURVEY.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Data
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly SurveyDbContext _context;

        public SurveyRepository(SurveyDbContext context)
        {
            _context = context;
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
            return _context.Cities.ToList();
        }
    }
}
