using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(userNameInput.Text) || string.IsNullOrWhiteSpace(passwordInput.Text))
			{
				MessageBox.Show(
					"Username and password are required",
					String.Empty,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}
	}
}
