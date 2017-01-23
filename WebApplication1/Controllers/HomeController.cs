using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetWeather()
        {
            Weather weather = new Weather();
            object content = weather.GetWeahterForecast();
            return Json(content, JsonRequestBehavior.AllowGet);
        }
    }
}