using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.Users
{
    public class UserCreatedDTO
    {
        [Required]
        [MaxLength(14)]
        [MinLength(5)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(6)]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [MinLength(3)]
        public string Firstname { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }


        [EmailAddress]
        public string Email { get; set; }
        public string Image { get; set; }
    }
}
