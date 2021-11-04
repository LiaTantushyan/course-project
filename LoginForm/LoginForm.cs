using System;
using System.Windows.Forms;
using LoginForm.Helpers.CommonServices;

namespace LoginForm
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void OnLoginButtonClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(userNameInput.Text) || string.IsNullOrWhiteSpace(passwordInput.Text))
			{
				Messages.Warning("Invalid data", "Username and password are both required.");
				return;
			}

			var isAuthorized = UserValidator.Authorize(userNameInput.Text, passwordInput.Text);
			if (isAuthorized)
			{
				Messages.Information("Redirect to main program", "Please click OK to redirect to main program.");

				loginButton.Enabled = false;
				loginButton.Visible = false;

				startAppButton.Enabled = true;
				startAppButton.Visible = true;
			}
		}
	}
}
