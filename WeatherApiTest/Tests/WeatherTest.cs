﻿using System;
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
        public void Weatherlatitude()
        {
            Assert.AreNotEqual(weatherapiservice.weatherDTO.latestWeather.coord.lat, 50.51);
        }

        [Test]
        public void testcoord()
        {
            Assert.IsNull(weatherapiservice.weatherDTO.latestWeather.coord);
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
            Assert.GreaterOrEqual(weatherapiservice.weatherDTO.latestWeather.wind.speed, 6);
        }
        [Test]
        public void testdatatype()
        {
          
        Assert.AreEqual(2,weatherapiservice.weatherDTO.latestWeather.sys.country.Length);
            
        }
        [Test]
        public void  MinTemp()
        {
         // Assert.IsInstanceOf(weatherapiservice.weatherDTO.latestWeather.main.temp_min.GetType());
        }
        [Test]
        public void Timezone()
        {
           Assert.AreEqual(weatherapiservice.weatherDTO.latestWeather.timezone, 3600);
        }
        [Test]
        public void testweather()
        {
            //    Assert.IsTrue(weatherapiservice.weatherDTO.latestWeather.weather[1].main);
            
           // Assert.That(weatherapiservice.weatherDTO.latestWeather);
        }

        [Test]
        public void clouds()
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
        public void CheckDescription()
        {
            Assert.IsNotNull(weatherapiservice.weatherDTO.latestWeather.weather[0].description);
        }

        [Test]
        public void testdata()
        {

            Assert.IsNotNull(weatherapiservice.weatherDTO.latestWeather.sys.country.Length);

        }
    }
}
