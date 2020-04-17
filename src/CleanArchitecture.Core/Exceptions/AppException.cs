using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Exceptions
{
    class AppException: Exception
    {
        public AppException(string message)
            :base(message)
        {

        }
    }
}
