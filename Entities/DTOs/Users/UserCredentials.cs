using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Users
{
    public class UserCredentials
    {
        [Required]
        [MaxLength(14)]
        [MinLength(5)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(6)]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
