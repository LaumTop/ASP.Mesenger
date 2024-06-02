using System.ComponentModel.DataAnnotations;

namespace Mesenger
{
    public class User
    {
        [Key]
        public int Id { get; set; } // Property with getter and setter for the primary key
        public string Username { get; set; } // Adjusted to use PascalCase for property names
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}