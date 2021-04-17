using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StaffMonitoring.Models;

namespace StaffMonitoring.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VacancyController : ControllerBase
    {
        [HttpPost]
        public void PostVacancySkills(IEnumerable<Vacancy> vacancies)
        {
        }
    }
}