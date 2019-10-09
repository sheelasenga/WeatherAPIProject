using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTest.Weather_API.Data_Handling
{
    class WeatherDTO
    {
        public WeatherModel latestWeather { get; set; }

public void DeserializeLatestWeather(String LatestWeatherResponse)
        {
            latestWeather = JsonConvert.DeserializeObject<WeatherModel>(LatestWeatherResponse);
        }
    }
}
