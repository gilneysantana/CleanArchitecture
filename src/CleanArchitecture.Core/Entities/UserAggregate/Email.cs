using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.UserAggregate
{
    public class Email
    {
        public string Address { get; private set; }

        public Email(string address)
        {
            //validate regex for email
            Address = address;
        }
    }
}
