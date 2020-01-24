using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab0E2.Models;

namespace Lab0E2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private MovieInterfaz _logger;

        public WeatherForecastController(MovieInterfaz logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public List<MovieClass> Get()
        {
            return _logger.library();
        }
        
        [HttpPost]
        public void Post([FromBody] MovieClass value)
        {
            _logger.Add(value);
           
        }
    }
}
