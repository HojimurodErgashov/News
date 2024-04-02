using Entities.Model.News;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Model.Users
{
    [Index(nameof(UserName), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Column("userId")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(14)]
        [MinLength(5)]
        public string UserName { get; set; }

        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public List<RoleEnum> Roles { get; set; }
        public bool IsActive { get; set; }
        public string Token { get; set; }
        public string Image { get; set; }
        public virtual List<New> News { get; set; }
    }
}