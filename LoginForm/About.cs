using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private  void About_Load(object sender, EventArgs e)
        {
            dateButton.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            label1.ForeColor = randomColor;
        }
    }
}
