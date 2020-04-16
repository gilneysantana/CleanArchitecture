using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.UserAggregate
{
    public class Credentials
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Credentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        internal Credentials ChangePassword(string currentPassword, string newPassword)
        {
            if (EncriptPassword(currentPassword) == Password)
                Password = EncriptPassword(newPassword);

            return this;
        }

        private string EncriptPassword(string clearPassword)
        {
            return "$%@#" + clearPassword + "#@%$";
        }
    }
}
