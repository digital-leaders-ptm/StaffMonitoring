using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StaffMonitoring.Models;
using StaffMonitoring.Models.DTO;

namespace StaffMonitoring.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionVacanciesController : ControllerBase
    {
        private readonly ApplicationContext db;

        public RegionVacanciesController(ApplicationContext db)
        {
            this.db = db;
        }

        [HttpPost]
        public void PostRegionVacancies(IEnumerable<RegionVacanciesDTO> regionVacanciesDtos)
        {
            foreach (var regionVacanciesDto in regionVacanciesDtos)
            {
            }

            db.SaveChanges();
        }
    }
}