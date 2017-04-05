using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class OpenWeatherMap
    {
        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class Sys
        {
            public int type { get; set; }
            public int id { get; set; }
            public double message { get; set; }
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
        }

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class Main
        {
            public double temp { get; set; }
            public int humidity { get; set; }
            public double pressure { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
        }

        public class Wind
        {
            public double speed { get; set; }
            public double gust { get; set; }
            public int deg { get; set; }
        }



        public class Clouds
        {
            public int all { get; set; }
        }

        public class Root
        {
            public Coord Coord { get; set; }
            public Sys Sys { get; set; }
            public List<Weather> Weather { get; set; }
            public string @Base { get; set; }
            public Main Main { get; set; }
            public Wind Wind { get; set; }
            public Dictionary<string, double> Rain { get; set; }
            public Clouds Clouds { get; set; }
            public int DT { get; set; }
            public int ID { get; set; }
            public string Name { get; set; }
            public int COD { get; set; }
        }
    }
}