using Microsoft.AspNetCore.Mvc;
using TestingApp.Models;
using TestingApp.Repository;

namespace TestingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IPlanningRepository _planningRepository;
        public WeatherForecastController(IPlanningRepository p)
        {
            _planningRepository = p;
        }


        private readonly ILogger<WeatherForecastController> _logger;


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Planning> planning = await _planningRepository.GetAll();
            return Ok(planning.ToArray());
            //return plannings.Any() ?
            //              (plannings.ToArray()) :
            //              Problem("Entity set 'TestingAppContext.Planning'  is null.");
        }


        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        //public IEnumerable<Planning> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new Planning
        //    {
        //        Week = 10,
        //        Hours = 500
        //    })
        //    .ToArray();
        //}


        //    private static readonly string[] Summaries = new[]
        //    {
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        //public async Task<IActionResult> Get()
        //{
        //    IEnumerable<Planning> plannings = await _planningRepository.GetAll();
        //    return plannings.Any() ?   
        //                  View(plannings.ToArray()) :
        //                  Problem("Entity set 'TestingAppContext.Planning'  is null.");
        //}
    }
}