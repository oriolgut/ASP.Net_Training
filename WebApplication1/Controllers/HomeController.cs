using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication1.Models;
using WebApplication1.ViewModels.Home;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private OpenWeatherMap.Root _weatherData;

        // GET: Home
        public ActionResult Index()
        {
            WeatherViewModel weather = new WeatherViewModel();
            GetWeather();
            weather.Icon = _weatherData.Weather.First().icon;
            weather.IconTitle = _weatherData.Weather.First().description;
            weather.CityName = _weatherData.Name;
            weather.Temperature = Convert.ToString(_weatherData.Main.temp);
            weather.Humidity = Convert.ToString(_weatherData.Main.humidity);
            return View(weather);
        }

        private void GetWeather()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(@"http://api.openweathermap.org/data/2.5/weather?q=Zurich&APPID=69015e4f8b7ba2ddb0cafcae485d3848&units=metric&mode=json");
                _weatherData = JsonConvert.DeserializeObject<OpenWeatherMap.Root>(json);
            }
        }
    }
}