using Newtonsoft.Json;

namespace whatsTheWeather.Shared.Models
{
    public class Wind
    {
        [JsonProperty("speed")]
        public decimal Speed { get; set; }

        [JsonProperty("deg")]
        public int Degress { get; set; }
    }
}
