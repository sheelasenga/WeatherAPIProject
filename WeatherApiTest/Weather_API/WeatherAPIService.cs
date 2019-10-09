using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApiTest.Weather_API.HTTP_Manager;
using WeatherApiTest.Weather_API.Data_Handling;
using Newtonsoft.Json.Linq;

namespace WeatherApiTest.Weather_API
{
    class WeatherAPIService
    {
        public WeatherDTO weatherDTO = new WeatherDTO();
        public WeatherCallManager weatherCallManager = new WeatherCallManager();
        public JObject WeatherApiJson;
        public WeatherAPIService()
        {
            weatherDTO.DeserializeLatestWeather(weatherCallManager.GetLatestWeather());
            WeatherApiJson = JObject.Parse(weatherCallManager.GetLatestWeather());
        }
       
    }
}
