using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using WebApplication1.Models;

namespace WebApplication1.ViewModels.Home
{
    public class WeatherViewModel
    {
        public string CityName { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }

    }
}