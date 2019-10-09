using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WeatherApiTest;

namespace WeatherApiTest.Weather_API.HTTP_Manager
{
    class WeatherCallManager
    {
        readonly IRestClient client;
        public WeatherCallManager()
        {
            client = new RestClient(WeatherConfig.BaseUrl);

        }
        public string GetLatestWeather()
        {
            var request = new RestRequest("/weather" + WeatherConfig.ApiUrlMod + "&" + WeatherConfig.ApiUrlMod1 + WeatherConfig.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
