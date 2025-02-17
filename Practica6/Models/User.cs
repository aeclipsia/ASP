namespace Practica6.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public byte[] Salt { get; set; }
        public byte[] Password { get; set; }
        public Role UserType { get; set; }


        public enum Role
        {
            Admin,
            Student
        }
    }
}