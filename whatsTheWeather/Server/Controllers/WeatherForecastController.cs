using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;
using whatsTheWeather.Shared.Models;
using Newtonsoft.Json;
using System;

namespace whatsTheWeather.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private static readonly HttpClient _client = new HttpClient();
        private readonly string _apiKey;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration config)
        {
            _logger = logger;
            _apiKey = config.GetSection("Services")["ApiKey"];
        }

        [HttpGet("cityName/{cityName}")]
        public async Task<ActionResult<WeatherForecast>> Get(string cityName)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&lang=lt&mode=json&appid={_apiKey}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<WeatherForecast>(responseBody);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }
    }
}
