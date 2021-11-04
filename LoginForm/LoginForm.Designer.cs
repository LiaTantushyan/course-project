
namespace LoginForm
{
	partial class LoginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.userNameInput = new System.Windows.Forms.TextBox();
			this.passwordInput = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.startAppButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// userNameInput
			// 
			this.userNameInput.Location = new System.Drawing.Point(56, 70);
			this.userNameInput.Name = "userNameInput";
			this.userNameInput.Size = new System.Drawing.Size(200, 24);
			this.userNameInput.TabIndex = 0;
			// 
			// passwordInput
			// 
			this.passwordInput.Location = new System.Drawing.Point(56, 116);
			this.passwordInput.Name = "passwordInput";
			this.passwordInput.PasswordChar = '•';
			this.passwordInput.Size = new System.Drawing.Size(200, 24);
			this.passwordInput.TabIndex = 1;
			// 
			// loginButton
			// 
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.loginButton.Location = new System.Drawing.Point(114, 157);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(77, 25);
			this.loginButton.TabIndex = 2;
			this.loginButton.Text = "Log In";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.OnLoginButtonClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// startAppButton
			// 
			this.startAppButton.Enabled = false;
			this.startAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.startAppButton.Location = new System.Drawing.Point(114, 188);
			this.startAppButton.Name = "startAppButton";
			this.startAppButton.Size = new System.Drawing.Size(77, 29);
			this.startAppButton.TabIndex = 5;
			this.startAppButton.Text = "Start";
			this.startAppButton.UseVisualStyleBackColor = true;
			this.startAppButton.Visible = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 229);
			this.Controls.Add(this.startAppButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordInput);
			this.Controls.Add(this.userNameInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox userNameInput;
		private System.Windows.Forms.TextBox passwordInput;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button startAppButton;
	}
}

