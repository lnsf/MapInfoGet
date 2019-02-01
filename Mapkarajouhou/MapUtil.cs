using CefSharp.WinForms;

namespace Mapkarajouhou
{
    public class MapClass
    {
        private ChromiumWebBrowser Browser;

        public MapClass(ChromiumWebBrowser browser)
        {
            Browser = browser;
        }

        public Location GetLocation()
        {
            var latRes = Browser.GetBrowser().GetFrame("").EvaluateScriptAsync("sendLatToCS();").Result;
            var lngRes = Browser.GetBrowser().GetFrame("").EvaluateScriptAsync("sendLngToCS();").Result;

            var lat = (string)latRes.Result;
            var lng = (string)lngRes.Result;

            return new Location(lat, lng);
        }

        public void SetLocation(Location location)
        {
            Browser.GetBrowser().GetFrame("").ExecuteJavaScriptAsync(string.Format("setMapCenter({0}, {1})",location.Lat, location.Lng));
        }
    }
}
