using System.Windows.Forms;

namespace LoginForm.Helpers.CommonServices
{
	public static class Messages
	{
		public static void Warning(string title, string content)
		{
			MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public static void Error(string title, string content)
		{
			MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void Information(string title, string content)
		{
			MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
