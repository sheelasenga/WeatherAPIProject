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
        public void Weatherlongitude()
        {
            Assert.AreEqual(weatherapiservice.weatherDTO.latestWeather.coord.lon, -0.13);
        }

        [Test]
        public void Weatherlongitudevalue()
        {
            Assert.NotNull(weatherapiservice.weatherDTO.latestWeather.coord.lon);
        }

        [Test]
        public void Weatherlatitude()
        {
            Assert.AreNotEqual(weatherapiservice.weatherDTO.latestWeather.coord.lat, 50.51);
        }

        [Test]
        public void testLatitudevalue()
        {
            Assert.AreEqual(weatherapiservice.weatherDTO.latestWeather.coord.lat,51.51);
        }

        [Test]
        public void testbase()
        {
            Assert.AreEqual("stations", weatherapiservice.weatherDTO.latestWeather.@base.ToString());
        }

        [Test]
        public void testpressure()
        {
            Assert.GreaterOrEqual(weatherapiservice.weatherDTO.latestWeather.main.pressure, 1000);
        }

        [Test]
        public void testArray()
        {
            Assert.Greater(weatherapiservice.weatherDTO.latestWeather.weather[0].id, 500);
        }

        [Test]
        public void testcod()
        {
            Assert.AreEqual(weatherapiservice.weatherDTO.latestWeather.cod, 200);
        }

        [Test]
        public void testsys()
        {
            Assert.AreEqual("GB", weatherapiservice.weatherDTO.latestWeather.sys.country.ToString());
        }

        [Test]
        public void testspeed()
        {
            Assert.GreaterOrEqual(weatherapiservice.weatherDTO.latestWeather.wind.speed, 4);
        }
        [Test]
        public void testdatatype()
        {
          
        Assert.AreEqual(2,weatherapiservice.weatherDTO.latestWeather.sys.country.Length);
            
        }
        [Test]
        public void  MinTemp()
        {
         Assert.That(weatherapiservice.weatherDTO.latestWeather.main.temp_min, Is.EqualTo(100).Within(300));
        }
        [Test]
        public void Timezonecheck()
        {
           Assert.AreEqual(weatherapiservice.weatherDTO.latestWeather.timezone, 3600);
        }
        [Test]
        public void testbaselength()
        {
        Assert.IsTrue(weatherapiservice.weatherDTO.latestWeather.@base.Length == 8);
        }

        [Test]
        public void cloudscheck()
        {
            Assert.LessOrEqual(weatherapiservice.weatherDTO.latestWeather.clouds.all, 100);
        }

        [Test]
        public void NameOfCity()
        {
            Assert.AreEqual("London",weatherapiservice.weatherDTO.latestWeather.name);
        }

        [Test]
        public void Citycheck()
        {
            Assert.IsNotNull(weatherapiservice.weatherDTO.latestWeather.name);
        }
        [Test]
        public void Idcheck()
        {
            Assert.IsNotNull(weatherapiservice.weatherDTO.latestWeather.id);
        }
        [Test]
        public void CityLengthcheck()
        {
            Assert.IsTrue(weatherapiservice.weatherDTO.latestWeather.name.Length == 6);
        }

        [Test]
        public void DescriptionCheck()
        {
            Assert.IsNotNull(weatherapiservice.weatherDTO.latestWeather.weather[0].description);
        }

        [Test]
        public void testcountrylength()
        {
        Assert.IsNotNull(weatherapiservice.weatherDTO.latestWeather.sys.country.Length);
        }

        [Test]
        public void testcountry()
        {
            Assert.IsNotNull(weatherapiservice.weatherDTO.latestWeather.main.humidity);
        }

        [Test]
        public void testLatitude()
        {
            Assert.IsNotNull(weatherapiservice.weatherDTO.latestWeather.coord.lat);
        }

        [Test]
        public void testsunrise()
        {
            Assert.IsNotNull(weatherapiservice.weatherDTO.latestWeather.sys.sunrise);
        }
    }
}
