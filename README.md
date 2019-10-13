# WeatherAPIProject

## Table of Contents
* [Introduction]https://github.com/sheelasenga/WeatherAPIProject/blob/master/README.md#introduction
* [Tests Implemented]https://github.com/sheelasenga/WeatherAPIProject/blob/master/README.md#tests-implemented
* [NuGet Packages]https://github.com/sheelasenga/WeatherAPIProject/blob/master/README.md#nuget-packages-used
* [Built with]https://github.com/sheelasenga/WeatherAPIProject/blob/master/README.md#built-with
* [Classes]https://github.com/sheelasenga/WeatherAPIProject/blob/master/README.md#classes
* [Conclusion]https://github.com/sheelasenga/WeatherAPIProject/blob/master/README.md#things-to-be-implemented 


## Introduction
Testing the Weather forcast API.

The aim of this project was to test the Weather API for the OpenWeatherMap 5 day forecast using unit test in c#.

## Running the Tests
1. Clone this git repository
2. Open the WeatherApiTest project in visual studio
3. Build the WeatherApiTest project by clicking on **Build Solution**.
4. Click on **Test Explorer**which will display the test window.
5. Click on the **Run All** button to run the tests.


## Tests Implemented
* Different data types were tested
* Numerical values were tested using Greater than or equal to
* Strings were tested using the length, IsNull, IsNotNull

## NuGet Packages used:
* NUnit
* RestSharp
* Newtonsoft.Json
* NUnit3TestAdapter

## Built with:
1. Visual Studio - The project was build and tested here in C#
2. Postman - A platform used for API development
3. Git - This platform was used for version control.
4. Openweather - This service provided the weather data.

## Classes

Four different classes were used.

WeatherDTO - The data tansfer object class was used to carry data between processes.

WeatherModel - This class contains the data types.

WeatherCallManager - This class was used to make API requests and get response.

WeatherAPIService - This class calls the deserialize method which is in the WeatherDTO class.

WeatherTests - This class contains all the different tests of the service.

## Things to be implemented

* Tests for date / time format
* Header tests should be carried out 
