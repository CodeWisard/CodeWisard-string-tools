using System;
using System.Windows.Forms;
using CryptoApi;

namespace SharpHash
{
    public partial class Main : Form
    {
        protected int UnixTimestamp;

        public Main()
        {
            InitializeComponent();
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
            string src;
            if (URD.Checked)
            {
                src = StringInput.Text + UnixTimestamp.ToString();
            }
            else
            {
                src = StringInput.Text;
            }
            string output = Hash.CryptoGeneric(Algorithm.Text, src, RD.Checked);
            Output.Text = output;
            Lenght.Text = "Lenght: " + output.Length;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            VersionLabel.Text = Properties.Settings.Default.Version;
            RD.Checked = Properties.Settings.Default.RD;
            URD.Checked = Properties.Settings.Default.URD;
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
            if (URD.Checked)
            {
                Properties.Settings.Default.URD = true;
            }
            else
            {
                Properties.Settings.Default.URD = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FileHashValidator val = new FileHashValidator();
            val.Show();
        }
    }
    public class Handlers
    {
        public static void Error(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
        }
    }
}
