using Newtonsoft.Json;

namespace whatsTheWeather.Shared.Models
{
    public class Main
    {
        [JsonProperty("temp")]
        public decimal Temperature { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }
    }
}