using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;

namespace Mapkarajouhou
{
    public class Weather
    {
        private static readonly string key = "Weather API Key";

        private Weather(JObject jobj)
        {
            string ConvertKToC(string k)
            {
                var k_float = float.Parse(k);
                var c_float = k_float - 273.15;
                var c = $"{c_float:F0}";
                return c;
            }

            var weather = jobj["weather"][0];
            Main = weather["main"].ToString();
            Description = weather["description"].ToString();
            Icon = weather["icon"].ToString();

            var main = jobj["main"];
            Temp = ConvertKToC(main["temp"].ToString());
            Pressure = main["pressure"].ToString();
            Humidity = main["humidity"].ToString();

            var coord = jobj["coord"];
            Lat = coord["lat"].ToString();
            Lng = coord["lon"].ToString();

            Name = jobj["name"].ToString();
            CityId = jobj["id"].ToString();            
        }


        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        public string Temp { get; set; }
        public string Pressure { get; set; }
        public string Humidity { get; set; }

        public string Lat { get; set; }
        public string Lng { get; set; }

        private string name;
        public string Name
        {
            get
            {
                return
                    name == "" ?
                    $"(緯度:{Lat} 経度:{Lng})" :
                    name;
            }
            set { name = value; }
        }
        public string CityId { get; set; }

        public static Weather GetWeatherFromWeb(Location lcn)
        {
            string url = $"http://api.openweathermap.org/data/2.5/weather?APPID={key}&lat={lcn.Lat}&lon={lcn.Lng}";

            try
            {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

                var res = new HttpClient().GetStringAsync(url).Result;

                var weather = JObject.Parse(res);

                return new Weather(weather);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace.ToString());
            }

            return null;
        }
    }
}