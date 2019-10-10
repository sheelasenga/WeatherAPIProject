# WeatherAPIProject

Testing the Weather forcast API.

The aim of this project was to test the Weather API for the OpenWeatherMap 5 day forecast using unit test in c#.

# Testing 
1. Different data types were tested
2. Numerical values were tested using Greater than or equal to
3. Strings were tested using the length, IsNull, IsNotNull
4. Header tests could also be carried out 

NuGet Packages used:
1. NUnit
2. RestSharp
3. Newtonsoft.Json
4. NUnit3TestAdapter

# Built with:
1. Visual Studio - The project was build and tested here in C#
2. Postman - A platform used for API development
3. Git - This platform was used for version control.
4. Openweather - This service provided the weather data.

Four different classes were used.

WeatherDTO - The data tansfer object class was used to carry data between processes.

WeatherModel - This class contains the data types.

WeatherCallManager - this class was used to make API requests and get response.

WeatherAPIService - This class calls the deserialize method which is in the WeatherDTO class.

WeatherTests - This class contains all the different tests of the service.
