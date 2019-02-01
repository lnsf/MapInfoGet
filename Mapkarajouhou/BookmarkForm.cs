using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapkarajouhou
{
    public partial class BookmarkForm : Form
    {
        public Location CityLocation { get; set; }

        public BookmarkedCity.City City { get; private set; }

        public string CityName { get; private set; }

        public BookmarkFormResult Result { get; private set; }

        public BookmarkForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameInput.Text == "")
            {
                MessageBox.Show("登録名を入力してください。");

                return;
            }

            this.Result = BookmarkFormResult.ADD;
            this.City = new BookmarkedCity.City(nameInput.Text, CityLocation.Lat, CityLocation.Lng);

            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nameInput.Text == "")
            {
                MessageBox.Show("登録名を入力してください。");

                return;
            }

            this.Result = BookmarkFormResult.DELETE;
            this.CityName = nameInput.Text;

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Result = BookmarkFormResult.CANCEL;

            this.Close();
        }
    }
}
