namespace BolsaTrabajo.Models
{
    public class RegisterModel
    {
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User.Roles Role { get; set; }
    }
}
