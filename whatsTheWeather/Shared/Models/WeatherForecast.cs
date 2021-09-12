using System.Collections.Generic;
using Newtonsoft.Json;

namespace whatsTheWeather.Shared.Models
{
    public class WeatherForecast
    {
        public List<Weather> Weather { get; set; }

        public Main Main { get; set; }

        public Wind Wind { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
