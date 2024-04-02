using Entities.Model.Users;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Entities.DTOs.Users
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<RoleEnum> Roles { get; set; }
        public string Image { get; set; }
    }
}