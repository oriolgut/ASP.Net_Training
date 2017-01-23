using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WebApplication1.Models
{
    public class Weather
    {
        public object GetWeahterForecast()
        {
            string url = "api.openweathermap.org/data/2.5/weather?q=Zurich&APPID=69015e4f8b7ba2ddb0cafcae485d3848&units=metric";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var jsSerializer = new JavaScriptSerializer();
            var jsContent = jsSerializer.Deserialize<object>(content);
            return jsContent;
        }
    }
}