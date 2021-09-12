using Newtonsoft.Json;

namespace whatsTheWeather.Shared.Models
{
    public class Weather
    {
        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
