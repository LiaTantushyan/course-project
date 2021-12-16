using System;
using System.IO;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            string text = Resources.Help.HelpText;
            helptext.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
