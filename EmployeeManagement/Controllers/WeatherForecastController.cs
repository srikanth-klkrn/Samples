using EmployeeManagement.DataManager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models;
using System.Net;
using SignalRApp1.Models;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly SchoolContext _context;
        private readonly IVMInstanceSsmCommandIdMappingDataService _vMInstanceSSMCommandIdMappingDataService;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, SchoolContext context, IVMInstanceSsmCommandIdMappingDataService vMInstanceSSMCommandIdMappingDataService)
        {
            _logger = logger;
            _context = context;
            _vMInstanceSSMCommandIdMappingDataService = vMInstanceSSMCommandIdMappingDataService;
        }

        [HttpPost]
  
   public void Create(Student student)
        {
            _logger.LogInformation($"In Controller {student.FirstMidName}");
        }

        [HttpGet]

        [Route("/connect/api/v1/healthz")]
        [ProducesResponseType(typeof(IEnumerable<GetAxAgentResponse>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<GetAxAgentResponse>>> GetHealthzAsync()
        {
            Console.WriteLine($"Called -healthz  {nameof(GetHealthzAsync)}");

            return Ok("healthz");
        }
    }
}
