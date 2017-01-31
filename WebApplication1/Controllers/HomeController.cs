using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        // GET: Home
        public ActionResult Index()
        {
            WeatherViewModel weather = new WeatherViewModel();
            OpenWeatherMap.Root weatherData;
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(@"http:\\api.openweathermap.org/data/2.5/weather?q=Zurich&APPID=69015e4f8b7ba2ddb0cafcae485d3848&units=metric&mode=json");
                weatherData = JsonConvert.DeserializeObject<OpenWeatherMap.Root>(json);
            }
            weather.CityName = weatherData.Name;
            weather.Temperature = Convert.ToString(weatherData.Main.temp);
            weather.Humidity = Convert.ToString(weatherData.Main.humidity);

            return View(weather);
        }
    }
}