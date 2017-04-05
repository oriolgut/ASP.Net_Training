using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;
using WebApplication1.ViewModels.Home;

namespace WebApplication1.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Index()
        {
            var weatherData = GetWeather();
            var weatherInformation = weatherData.Weather.FirstOrDefault();
            WeatherViewModel weather = new WeatherViewModel
            {
                Icon = weatherInformation?.icon,
                IconTitle = weatherInformation?.description,
                CityName = weatherData.Name,
                Temperature = Convert.ToString(weatherData.Main.temp, CultureInfo.InvariantCulture),
                Humidity = Convert.ToString(weatherData.Main.humidity)
            };
            return View(weather);
        }

        private OpenWeatherMap.Root GetWeather()
        {
            using (var wc = new WebClient())
            {
                var json = wc.DownloadString(@"http://api.openweathermap.org/data/2.5/weather?q=Zurich&APPID=69015e4f8b7ba2ddb0cafcae485d3848&units=metric&mode=json");
                return JsonConvert.DeserializeObject<OpenWeatherMap.Root>(json);
            }
        }
    }
}