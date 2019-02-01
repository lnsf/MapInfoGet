using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
namespace Mapkarajouhou
{
    public partial class Form1 : Form
    {
        private BookmarkedCity ReadBookmark()
        {
            string filePath = Directory.GetCurrentDirectory() + "\\bookmark.json";
            string readText = "";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "{\"Cities\":[]}");
            }

            readText = File.ReadAllText(filePath);

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

                    return;
                }

                return;
            }

            MessageBox.Show("削除を指示したブックマークは見つかりませんでした。");
        }

        private void SetDisplay()
        {
            weatherText.Items.Clear();

            string[] text = {
                string.Format("選択地点： {0}",weather.Name),
                "",
                string.Format("天気： {0}",weather.Main),
                string.Format("詳細： {0}",weather.Description),
                "",
                string.Format("気温： {0}℃",weather.Temp),
                string.Format("湿度： {0}%",weather.Humidity),
                string.Format("気圧： {0}hPa",weather.Pressure),
            };

            foreach (var t in text)
            {
                weatherText.Items.Add(t);
            }

            weatherPicture.ImageLocation = string.Format("http://openweathermap.org/img/w/{0}.png", weather.Icon);
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