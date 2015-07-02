using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileVault
{
    public partial class FileVault : Form
    {
        public FileVault()
        {
            InitializeComponent();
        }

        private void OpenOptionsDialog_Click(object sender, EventArgs e)
        {
            Settings SettingsView = new Settings();
            SettingsView.Show();
        }
    }
}
