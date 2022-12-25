using System;
using Service.Constants;
using Service.Enums;
using Service.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace Service
{
    public class Account : IAccount
    {
        public string CheckRole(string email, string password, Role role)
        {
            if (email == "test@code.edu.az" && password == "test12345" && role == Role.SuperAdmin)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Successful login";
            }

            else if (email == "test@code.edu.az" && password == "test12345" && role != Role.SuperAdmin)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return Errors.AccessIsDenied;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return Errors.InvalidData;
            }
        }
    }
}

