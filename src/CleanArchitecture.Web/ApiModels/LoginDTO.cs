using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Web.ApiModels
{
    // Note: doesn't expose events or behavior
    public class LoginDTO
    {
        public string username { get; set; }
        public string Password { get; set; }
        public string _id { get; set; }

    }
}
