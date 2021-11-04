using LoginForm.Helpers.Constants.Users;
using LoginForm.Models;

namespace LoginForm.Helpers.CommonServices
{
	public static class UserValidator
	{
		public static bool Authorize(string username, string password)
		{
			var user = new User
			{
				Username = username,
				Password = password
			};
			user.Password = PasswordHasher.ComputeHash(user.Password);

			if (user.IsRegistered())
			{
				Messages.Information("Login succeeded!", $"Login and authorization was succeeded for user '{user.Username}'!");
				return true;
			}

			Messages.Error("Login failed!", "Login was failed due to incorrect login or password.\nPlease try again.");
			return false;
		}

		private static bool IsRegistered(this User user)
		{
			return Users.RegisteredUsers.Exists(i => i.Username == user.Username && i.Password == user.Password);
		}
	}
}
