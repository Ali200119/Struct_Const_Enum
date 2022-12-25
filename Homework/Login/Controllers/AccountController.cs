using System;
using Service;
using Service.Enums;
using Service.Interfaces;

namespace Login.Controllers
{
	public class AccountController
	{
		public void Login()
		{
			IAccount account = new Account();

			Console.Write ("Please, enter your email: ");
			string email = Console.ReadLine();

			Console.Write("Enter your password: ");
			string password = Console.ReadLine();

			Console.Write("Enter your role ID: ");

			Role: int roleId = int.Parse(Console.ReadLine());

			Role role;

			switch (roleId)
			{
				case (int)Role.SuperAdmin:
					role = Role.SuperAdmin;
					break;

				case (int)Role.Admin:
					role = Role.Admin;
					break;

				case (int)Role.Member:
					role = Role.Member;
					break;

				default:
					Console.Write("Please enter valid value: ");
					goto Role;
			}

			Console.WriteLine(account.CheckRole(email, password, role));
		}
    }
}

