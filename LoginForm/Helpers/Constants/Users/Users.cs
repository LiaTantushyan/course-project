using System.Collections.Generic;
using LoginForm.Models;

namespace LoginForm.Helpers.Constants.Users
{
	public static class Users
	{
		public static readonly List<User> RegisteredUsers = new List<User>();

		static Users()
		{
			RegisteredUsers.Add(new User
			{
				Username = Usernames.user1, 
				Password = Passwords.user1Password
			});

			RegisteredUsers.Add(new User
			{
				Username = Usernames.user2,
				Password = Passwords.user2Password
			});
		}

		private static class Usernames
		{
			public const string user1 = "benatanesyan2@gmail.com";
			public const string user2 = "lia.2003.tantushyan@gmail.com";
		}

		private static class Passwords
		{
			public const string user1Password = "e3a4933558fed7f68e547b30fc523f6f263b841da815eb2c6a88bfd4c8d1a57d";
			public const string user2Password = "a07a43ca134d73e450f36711318beb6c8a40e7229902f4627ea03086c192d615";
		}
	}
}
