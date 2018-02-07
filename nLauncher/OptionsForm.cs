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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_entriesHeight.Text != "") {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).ResizeEntries(Convert.ToInt32(txt_entriesHeight.Text));
            }
        }
    }
}
