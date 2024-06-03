namespace Messenger.Models
{
    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Users(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}