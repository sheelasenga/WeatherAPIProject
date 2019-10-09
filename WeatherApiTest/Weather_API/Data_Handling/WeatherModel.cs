using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApiTest.Weather_API.Data_Handling
{
   public  class WeatherModel
    {
       public Coord coord { get; set; }
       public Main main { get; set; }
       public string  @base { get; set; }
       public IList<Weather> weather { get; set; }
       public double cod { get; set; }
       public Sys sys { get; set; }
       public Wind wind { get; set; }
        public double timezone { get; set; }

    }
    public class Coord
        {
           public double lon { get; set; }
           public double lat { get; set; }
       }

    public class Weather
    {
        public int id { get; set;}
        public string main { get; set; }
        public  string description { get; set; }
        public string icon { get; set; }
    }
   
    public class Main
    {
        public double pressure { get; set;}
        public double temp_min { get; set; }
        public double temp_max { get; set; }

    }

    public class Sys
    {
        public string country { get; set;}
    }

    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
    }



}
