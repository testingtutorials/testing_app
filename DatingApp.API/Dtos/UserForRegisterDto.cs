using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Specify password between 4 and 20 characters")]
        public string Password { get; set; }
    }
}