using System.ComponentModel.DataAnnotations;

namespace TodoApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password must be between 4 and 8")]
        public string Password { get; set; }
    }

    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}