using System.ComponentModel.DataAnnotations;

namespace DriveSafe.Users.Models
{
    public class RegisterUserDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public DateTime Birthdate { get; set; }
        
        [Required]
        public string Cellphone { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        
        [Required]
        public string Type { get; set; }
    }
}