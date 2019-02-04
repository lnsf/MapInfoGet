using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Mapkarajouhou
{
    public partial class Form1 : Form
    {
        private BookmarkedCity ReadBookmark()
        {
            string filePath = $"{Directory.GetCurrentDirectory()}\\bookmark.json";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "{\"Cities\":[]}");
            }

            string readText = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<BookmarkedCity>(readText);

        }

        private void SetBookmarkMenu()
        {
            bookmarkMenuItem.DropDownItems.Clear();

            foreach (var city in bookmark.Cities)
            {
                bookmarkMenuItem.DropDownItems.Add(city.Name);
            }
        }

        private void DeleteBookmark(string name)
        {
            for (var i = 0; i < bookmark.Cities.Count; i++)
            {
                if (bookmark.Cities[i].Name != name)
                    continue;

                var res = MessageBox.Show(
                        "指定された名前のブックマークを削除します。",
                        "確認",
                        MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    bookmark.Cities.RemoveAt(i);

                    SetBookmarkMenu();
                }

                return;
            }

            MessageBox.Show("削除を指示したブックマークは見つかりませんでした。");
        }

        private void SetDisplay()
        {
            weatherText.Items.Clear();

            string[] text = {
                $"選択地点： {weather.Name}",
                "",
                $"天気： {weather.Main}",
                $"詳細： {weather.Description}",
                "",
                $"気温： {weather.Temp}℃",
                $"湿度： {weather.Humidity}%",
                $"気圧： {weather.Pressure}hPa",
            };

            foreach (var t in text)
            {
                weatherText.Items.Add(t);
            }

            weatherPicture.ImageLocation = $"http://openweathermap.org/img/w/{weather.Icon}.png";
        }

        private void AddBookmark(BookmarkedCity.City city)
        {
            for (var i = 0; i < bookmark.Cities.Count; i++)
            {
                if (bookmark.Cities[i].Name != city.Name)
                    continue;

                var res = MessageBox.Show(
                        "指定された名前のブックマークは存在します。\n上書きしますか？",
                        "確認",
                        MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    bookmark.Cities.RemoveAt(i);
                    bookmark.Cities.Insert(i, city);

                    SetBookmarkMenu();
                }

                return;
            }

            bookmark.Cities.Add(city);
            SetBookmarkMenu();
        }
    }
}