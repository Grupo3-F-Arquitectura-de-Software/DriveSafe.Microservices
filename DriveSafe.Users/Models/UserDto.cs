namespace DriveSafe.Users.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
    }
}