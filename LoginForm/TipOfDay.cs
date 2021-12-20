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
            tipOfDay1.Text = Resources.Tips.TipOfDay1;
        }

        private void nextTip_Click(object sender, EventArgs e)
        {
            if (tipOfDay1.Text == Resources.Tips.TipOfDay1)
            {
                tipOfDay1.Text = Resources.Tips.TipOfDay2;
            }
            else
            {
                tipOfDay1.Text = Resources.Tips.TipOfDay1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            tipOfDay1.Text = Resources.Tips.TipOfDay1;
        }
    }
}
