using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nLauncher
{
    public partial class AppEntryDetailsForm : Form
    {
        public AppEntryDetailsForm()
        {
            InitializeComponent();
        }

        public void InitializeValuesFromShortcut(ShortcutInfo sInfo)
        {
            txt_id.Text = "1";
            txt_name.Text = sInfo.Name;
            txt_path.Text = sInfo.Path;

        }

        private void btn_searchImage_Click(object sender, EventArgs e)
        {
            SearchWindow search = new SearchWindow();
            search.Show();
            search.Search(txt_name.Text);
        }

        public void setImage1(string value)
        {
            txt_image1.Text = value;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DbController.AddEntry(txt_name.Text, txt_path.Text, txt_image1.Text);
            (System.Windows.Forms.Application.OpenForms["AppEntryDetailsForm"] as AppEntryDetailsForm).Hide();
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).ShowAppEntries();
        }
    }
}
