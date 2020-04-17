using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities
{
    public class Credentials
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Credentials(string username, string password)
        {
            Username = username;
            Password = EncriptPassword(password);
        }

        internal Credentials ChangePassword(string currentPassword, string newPassword)
        {
            if (EncriptPassword(currentPassword) == Password)
                Password = EncriptPassword(newPassword);

            return this;
        }

        public static string EncriptPassword(string clearPassword)
        {
            return "$%@#" + clearPassword + "#@%$";
        }
    }
}
