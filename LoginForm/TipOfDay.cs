using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class TipOfDay : Form
    {
        public TipOfDay()
        {
            InitializeComponent();
        }

        private void TipOfDay_Load(object sender, EventArgs e)
        {
            string str = Resources.Tip1.Tip_1;

            tipOfDay1.Text = str;
        }

        private void nextTip_Click(object sender, EventArgs e)
        {
            tipOfDay1.Text = string.Empty;
            string str = Resources.Tip2.Tip_2;
            tipOfDay1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            string str = Resources.Tip1.Tip_1;
            tipOfDay1.Text = str;
        }
    }
}
