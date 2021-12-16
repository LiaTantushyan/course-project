using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class NameSurnameForm : Form
    {
        public NameSurnameForm()
        {
            InitializeComponent();
        }

        private void NameSurnameForm_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.UtcNow.Date.ToLongDateString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            timer1.Tick += TimerEventProcessor;
            timer1.Start();
        }

        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEvent)
        {
            timer1.Stop();
            timer1.Enabled = false;
            this.Location = new Point(this.Location.X + 200, this.Location.Y + 400);
            Thread.Sleep(1000);
            this.Location = new Point(this.Location.X + 200, this.Location.Y - 400);
            Thread.Sleep(1000);

            Program.CloseCurrentAndOpenNext(this, new LoginForm());
        }
    }
}
