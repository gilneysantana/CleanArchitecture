using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Web.ApiModels
{
    // Note: doesn't expose events or behavior
    public class UserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public static UserDTO FromUser(User user)
        {
            return new UserDTO()
            {
                Name = user.Name,
                Email = user.Email.Address
            };
        }

    }
}
