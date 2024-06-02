using Newtonsoft.Json;

public class Json
{
    public async Task<List<User>> LoadUsers()
    {
        string fileName = "users.json";
        List<User> users;
        if (File.Exists(fileName))
        {
            string json = await File.ReadAllTextAsync(fileName);
            users = JsonConvert.DeserializeObject<List<User>>(json);
        }
        else
        {
            users = new List<User>();
        }
        return users;
    }

    public async Task SaveUsers(List<User> users)
    {
        string fileName = "users.json";
        string json = JsonConvert.SerializeObject(users);
        await File.WriteAllTextAsync(fileName, json);
    }
}

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}