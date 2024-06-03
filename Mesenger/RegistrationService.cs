using Messenger.Models;
using System.Collections.Generic;

namespace Messenger.Services
{
    public class RegistrationService
    {
        public List<KeyValuePair<string, string>> ConfirmRegister { get; } = new List<KeyValuePair<string, string>>();
        public List<string> SecretCodes { get; } = new List<string>();
        public List<Users> RequestedUsers { get; } = new List<Users>();
    }
}