using LoginForm.Helpers.Constants.Users;
using LoginForm.Models;

namespace LoginForm.Helpers.CommonServices
{
	public static class UserValidator
	{
		public static bool Authorize(string username, string password)
		{
			var user = new UserModel
			{
				Username = username,
				Password = password.Hash()
			};

			if (user.IsRegistered())
			{
				return true;
			}

			Messages.Error("Login failed!", "Login was failed due to incorrect login or password.\nPlease try again.");
			return false;
		}

		private static bool IsRegistered(this UserModel user)
		{
			return Users.RegisteredUsers.Exists(i => i.Username == user.Username && i.Password == user.Password);
		}
	}
}
