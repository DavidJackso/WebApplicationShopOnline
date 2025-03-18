using System.Security.Cryptography.X509Certificates;

namespace WebApplicationShopOnline.Models
{
    public class User
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string name,string email,string password)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;
        }
        public override string ToString()
        {
            return $"{Id},{Name},{Email},{Password}";
        }
    }
}
