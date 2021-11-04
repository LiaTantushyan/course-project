using System.Security.Cryptography;
using System.Text;

namespace LoginForm.Helpers.CommonServices
{
	public static class PasswordHasher
	{
		public static string ComputeHash(string rawData)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));

				StringBuilder builder = new StringBuilder();
				foreach (var element in bytes)
				{
					builder.Append(element.ToString("x2"));
				}

				return builder.ToString();
			}
		}
	}
}
