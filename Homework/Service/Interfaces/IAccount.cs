using System;
using Service.Enums;

namespace Service.Interfaces
{
	public interface IAccount
	{
		string CheckRole(string email, string password, Role role);
	}
}