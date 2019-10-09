using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RestSharp;
using WeatherApiTest.Weather_API;
namespace WeatherApiTest.Tests
{
    [TestFixture]
    public class WeatherTest
    {
        private WeatherAPIService weatherapiservice = new WeatherAPIService();

        [Test]
        public void Weather()
        {
  //          Assert.AreEqual(weatherapiservice.weatherDTO.latestWeather.coord,null);
        }

        [Test]
        public void Weatherlongitude()
        {
      //      Assert.AreEqual(weatherapiservice.weatherDTO.latestWeather.coord.lon, -0.13);
        }

        [Test]
        public void Weatherlatitude()
        {
     //      Assert.AreEqual(weatherapiservice.weatherDTO.latestWeather.coord.lat, 51.51);
        }

        [Test]
        public void testcoord()
        {
     //       Assert.AreEqual(null, weatherapiservice.weatherDTO.latestWeather.coord);
        }

        [Test]
        public void testbase()
        {
            Assert.AreEqual("stations",weatherapiservice.weatherDTO.latestWeather.@base.ToString());
        }
    }
}
