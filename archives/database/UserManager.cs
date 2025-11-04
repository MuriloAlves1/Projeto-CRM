using System.Text.Json; //pra converter dados entre objeto ↔ texto JSON.

public class UserManager
{
    private string filePath = "users.json";
    private List<User> users = new List<User>();

    public UserManager()
    {
        LoadUsers();
    }

    // Classe interna que representa o usuário
    private class User
    {
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    // Cria uma nova conta
    public bool CreateAccount(string login, string password)
    {
        // Verifica se já existe
        if (users.Exists(u => u.Login == login))
        {
            return false; // já existe
        }

        users.Add(new User { Login = login, Password = password });
        SaveUsers();
        return true;
    }

    // Faz login
    public bool Login(string login, string password)
    {
        return users.Exists(u => u.Login == login && u.Password == password);
    }

    // Salva os usuários no arquivo JSON
    private void SaveUsers()
    {
        string json = JsonSerializer.Serialize(users);
        File.WriteAllText(filePath, json);
    }

    // Carrega os usuários do arquivo JSON
    private void LoadUsers()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
    }
}
