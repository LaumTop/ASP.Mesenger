using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Messenger.Models;
using Newtonsoft.Json;

public class Json
{
    private const string FileName = "users.json";

    public async Task<List<Users>> LoadUsers()
    {
        List<Users> users;
        if (File.Exists(FileName))
        {
            string json = await File.ReadAllTextAsync(FileName);
            users = JsonConvert.DeserializeObject<List<Users>>(json);
        }
        else
        {
            users = new List<Users>();
        }
        return users;
    }

    public async Task SaveUsers(List<Users> users)
    {
        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        await File.WriteAllTextAsync(FileName, json);
    }
}