using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;

namespace Mapkarajouhou
{
    public class Weather
    {
        private static string key = "Weather API Key";

        private Weather(JObject jobj)
        {
            Func<string, string> ConvertKToC = (string k) =>
            {
                var k_float = float.Parse(k);
                var c_float = k_float - 273.15;
                var c = string.Format("{0:F0}", c_float);
                return c;
            };

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
                    string.Format("(緯度:{0} 経度:{1})", Lat, Lng) :
                    name;
            }
            set { name = value; }
        }
        public string CityId { get; set; }

        public static Weather GetWeatherFromWeb(Location lcn)
        {
            string baseUrl = "http://api.openweathermap.org/data/2.5/weather";

            string url = string.Format("{0}?APPID={1}&lat={2}&lon={3}", baseUrl, key, lcn.Lat, lcn.Lng);

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