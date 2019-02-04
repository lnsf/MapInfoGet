using CefSharp.WinForms;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Mapkarajouhou
{
    public partial class Form1 : Form
    {
        private MapClass map = null;
        private Weather weather = null;
        private BookmarkedCity bookmark = null;

        public Form1()
        {
            InitializeComponent();

            var browser = new ChromiumWebBrowser($"file:///{Directory.GetCurrentDirectory().Replace('\\', '/')}/Map.html");

            leftTableLayout.Controls.Add(browser, 0, 0);

            browser.FrameLoadEnd += (sender, e) =>
            {
                Invoke((MethodInvoker)(() =>
                {
                    searchButton.Enabled = true;
                    bookmarkButton.Enabled = true;
                }));
            };

            map = new MapClass(browser);

            bookmark = ReadBookmark();

            SetBookmarkMenu();
        }

        private void SearchButtonClicked(object sender, EventArgs e)
        {
            searchButton.Enabled = false;

            var l = map.GetLocation();

            weather = Weather.GetWeatherFromWeb(l);

            if (weather == null)
            {
                searchButton.Enabled = true;
                return;
            }

            SetDisplay();

            searchButton.Enabled = true;
        }

        private void BookmarkMenuItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var clickedText = e.ClickedItem.Text;

            Location location = null;

            bookmark.Cities.ForEach(bk =>
            {
                if (bk.Name == clickedText)
                {
                    location = new Location(bk.Lat, bk.Lng);
                }
            });

            if (location == null)
                return;

            map.SetLocation(location);
        }

        private void TweetButtonClicked(object sender, EventArgs e)
        {
            if (weather == null)
            {
                MessageBox.Show("場所をマップで検索してからもう一度お試しください。");

                return;
            }

            var tweetStr =
                WebUtility.UrlEncode(
                    $"{weather.Name}の天気\n" +
                    $"{weather.Main} --- {weather.Description}\n\n" +
                    $"気温：{weather.Temp}℃\n" +
                    $"湿度：{weather.Humidity}%\n" +
                    $"気圧：{weather.Pressure}hPa");

            var url = $"https://twitter.com/intent/tweet?text={tweetStr}";

            // ブラウザを起動
            Process.Start(url);
        }

        private void WeatherButtonClicked(object sender, EventArgs e)
        {
            if (weather == null)
            {
                MessageBox.Show("場所をマップで検索してからもう一度お試しください。");

                return;
            }

            string url = weather.CityId == "0"
                ? $"https://openweathermap.org/weathermap?lat={weather.Lng}&lon={2}&zoom=5"
                : $"https://openweathermap.org/city/{weather.CityId}";

            Process.Start(url);
        }

        private void BookmarkButtonClicked(object sender, EventArgs e)
        {
            var form = new BookmarkForm();
            var location = map.GetLocation();
            form.CityLocation = location;

            form.ShowDialog();

            switch (form.Result)
            {
                case BookmarkFormResult.ADD:
                    AddBookmark(form.City);
                    break;

                case BookmarkFormResult.DELETE:
                    DeleteBookmark(form.CityName);
                    break;

                case BookmarkFormResult.CANCEL:
                    break;
            }

            form.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\bookmark.json";
            string json = JsonConvert.SerializeObject(bookmark);

            File.WriteAllText(filePath, json);

            return;
        }
    }
}
