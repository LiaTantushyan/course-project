using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class MainForm : Form
    {
        private static List<Form> Forms = new();

        public MainForm()
        {
            InitializeComponent();
            Forms = new List<Form>
            {
                new Form1(),
                new TipOfDay(),
                new Help(),
                new About()
            };
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show("Are you sure to exit?",
               "Warning",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void AppMainButton_Click(object sender, EventArgs e)
        {
            var titleForm = Forms.FirstOrDefault(i => i.GetType() == typeof(Form1));
            titleForm.Show();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = Forms.FirstOrDefault(i => i.GetType() == typeof(About));
            aboutForm.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpForm = Forms.FirstOrDefault(i => i.GetType() == typeof(Help));
            helpForm.Show();
        }

        private void closeAllStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var form in Forms)
            {
                form.Hide();
            }
        }

        private void tipOfDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tipOfDayForm = Forms.FirstOrDefault(i => i.GetType() == typeof(TipOfDay));
            tipOfDayForm.Show();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Program.CloseCurrentAndOpenNext(this, new TaskForm());
        }

        private void cascadButton_Click(object sender, EventArgs e)
        {
            Forms.Add(this);
            Forms.Reverse();
            var enumerator = Forms.GetEnumerator();
            SortForm();
            ArrangeCascade(enumerator, this);
            Forms.Remove(this);
        }

        private void ArrangeCascade(IEnumerator enumerator, Form previous)
        {
            if (enumerator.MoveNext())
            {
                var current = (Form)enumerator.Current;
                current.Left = previous.Left + 30;
                current.Top = previous.Top + 60;

                ArrangeCascade(enumerator, current);
            }
        }

        private void horizontalyButton_Click(object sender, EventArgs e)
        {

            Forms.Add(this);
            Forms.Reverse();
            var enumerator = Forms.GetEnumerator();
            ArrangeVertically(enumerator, this);
            Forms.Remove(this);
        }
        private void SortForm()
        {
            foreach (var item in Forms)
            {
                Screen screen = Screen.FromControl(this);

                Rectangle workingArea = screen.WorkingArea;
                item.Location = new Point()
                {
                    X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                    Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
                };
            }
        }
        private void ArrangeVertically(IEnumerator enumerator, Form previous)
        {

            if (enumerator.MoveNext())
            {
                var current = (Form)enumerator.Current;
                current.Top = previous.Top + 60;

                ArrangeVertically(enumerator, current);
            }
        }
    }
}