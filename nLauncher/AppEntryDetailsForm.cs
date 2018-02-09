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
            txt_name.Text = sInfo.Name;
            txt_path.Text = sInfo.Path;
        }

        public void InitializeValuesFromEntry(AppEntry entry)
        {
            txt_id.Text = entry.Id.ToString();
            txt_name.Text = entry.Name;
            txt_path.Text = entry.Path;
            txt_image1.Text = entry.Image1;
            if (entry.Image2 != null) { txt_image2.Text = entry.Image2.Length.ToString(); }
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
            if (txt_id.Text == "")
            {
                AppEntry newApp = DbController.AddEntry(txt_name.Text, txt_path.Text, txt_image1.Text);
                (System.Windows.Forms.Application.OpenForms["AppEntryDetailsForm"] as AppEntryDetailsForm).Close();
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).ShowAppEntries();
            }
            else
            {
                AppEntry modifyApp = DbController.GetEntry(Convert.ToInt32(txt_id.Text));
                modifyApp.Image1 = txt_image1.Text;
                modifyApp.Name = txt_name.Text;
                modifyApp.Path = txt_path.Text;
                DbController.ModifyEntry(modifyApp);
                (System.Windows.Forms.Application.OpenForms["AppEntryDetailsForm"] as AppEntryDetailsForm).Close();
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).ShowAppEntries();
            }
        }

        private void AppEntryDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
