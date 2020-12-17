using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using OGS.STV.SURVEY.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.STV.SURVEY.Data
{
    public class SurveySeeder
    {
        private readonly SurveyDbContext _context;
        private readonly IWebHostEnvironment _hosting;
        private readonly UserManager<IdentityUser> _userManager;

        public SurveySeeder(SurveyDbContext context, IWebHostEnvironment hosting, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _hosting = hosting;
            _userManager = userManager;
        }
        public async Task SeedAsync()
        {
            _context.Database.EnsureCreated();
            IdentityUser user = await _userManager.FindByNameAsync("mmdilmen@gmail.com");
            IdentityUser user2 = await _userManager.FindByNameAsync("sisliterakki@oyakgrupsigorta.com");
            if (user == null && user2 == null)
            {
                user = new IdentityUser()
                {
                    Email = "mmdilmen@gmail.com",
                    UserName = "mmdilmen@gmail.com"
                };
                var result = await _userManager.CreateAsync(user, "123asd123!A");
                
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Seeder for user just exploded !!");
                }
                user2 = new IdentityUser()
                {
                    Email = "sisliterakki@oyakgrupsigorta.com",
                    UserName = "sisliterakki@oyakgrupsigorta.com"
                };
                var result2 = await _userManager.CreateAsync(user2, "123asd123!A");                
                if (result2 != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Seeder for user just exploded !!");
                }

            }
        }
    }
}
