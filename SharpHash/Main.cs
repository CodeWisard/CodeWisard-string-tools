using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Util;
using System.Text.RegularExpressions;

namespace SharpHash
{
    public partial class Main : Form
    {
        protected int UnixTimestamp;

        public Main()
        {
            InitializeComponent();
        }

        private void RandomDataInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RandomDataInput_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void KeyRefresh_Tick(object sender, EventArgs e)
        {
            UnixTimestamp = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            TimeStampDisplay.Text = UnixTimestamp.ToString();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string src = StringInput.Text + UnixTimestamp.ToString() + RandomDataInput.Text;
            byte[] src_prep = ASCIIEncoding.ASCII.GetBytes(src);
            byte[] hash;
            if (Algorithm.Text == null || Algorithm.Text == "" || Algorithm.Text == "Algorithm")
            {
                hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(src_prep);
            }
            else
            {
                hash = ((HashAlgorithm)CryptoConfig.CreateFromName(Algorithm.Text)).ComputeHash(src_prep);
            }
            
            if (RD.Checked)
            {
                Output.Text = BitConverter.ToString(hash).Replace("-", string.Empty);
            }
            else
            {
                Output.Text = BitConverter.ToString(hash);
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            VersionLabel.Text = Properties.Settings.Default.Version;
            RD.Checked = Properties.Settings.Default.RD;
        }

        private void RD_CheckedChanged(object sender, EventArgs e)
        {
            if (RD.Checked)
            {
                Properties.Settings.Default.RD = true;
            }
            else
            {
                Properties.Settings.Default.RD = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
