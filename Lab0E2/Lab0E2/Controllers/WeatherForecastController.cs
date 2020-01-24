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
        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}
        [HttpGet]
        public List<MovieClass> Get()
        {
            MovieSettings set = new MovieSettings();
            return Singleton.Instance.MovieClass;
        }
        
        [HttpPost]
        public void Post([FromBody] MovieClass value)
        {
            MovieSettings moviepost = new MovieSettings();
            Singleton.Instance.MovieClass.Add(value);
            moviepost.Add(value);
        }
    }
}
