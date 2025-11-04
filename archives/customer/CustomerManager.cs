using System.Text.Json;

internal class CustomerManager
{
    // CLASSE DOS CLIENTES
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Cellphone { get; set; } = string.Empty;
    }

    // Caminho do arquivo JSON
    private string fileCustomerPath = "C:/Users/Murilo/source/repos/Projetos-Console/Projeto3/archives/customer/customers.json";

    // Lista de clientes em memória
    private List<Customer> customerList = new List<Customer>();

    // Construtor - carrega os clientes salvos
    public CustomerManager()
    {
        LoadCustomer();
    }

    // MÉTODO PARA CRIAR CLIENTE
    public bool CreateCustomer(string Name, string Email, string Cellphone)
    {
        // verifica se já existe cliente igual
        if (customerList.Exists(x => x.Name == Name && x.Email == Email && x.Cellphone == Cellphone))
        {
            return false;
        }

        // gera ID automático
        int newId = customerList.Count > 0 ? customerList.Max(x => x.Id) + 1 : 1;

        // adiciona novo cliente
        customerList.Add(new Customer
        {
            Id = newId,
            Name = Name,
            Email = Email,
            Cellphone = Cellphone
        });

        SaveCustomers();
        return true;
    }

    // SALVA CLIENTES NO JSON
    private void SaveCustomers()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(fileCustomerPath)!);

        string json = JsonSerializer.Serialize(customerList, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileCustomerPath, json);
    }

    // CARREGA CLIENTES DO JSON
    private void LoadCustomer()
    {
        if (File.Exists(fileCustomerPath))
        {
            string json = File.ReadAllText(fileCustomerPath);
            customerList = JsonSerializer.Deserialize<List<Customer>>(json) ?? new List<Customer>();
        }
    }

    // MENU DE CLIENTES
    public void CustomerList()
    {
        Console.WriteLine("CLIENTES");
        Console.WriteLine("▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁");
        Console.WriteLine("1. Cadastrar cliente");
        Console.WriteLine("2. Listar clientes");
        Console.WriteLine("3. Atualizar cliente");
        Console.WriteLine("4. Excluir cliente");
        Console.WriteLine("0. Sair");

        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 0:
                Console.WriteLine("Saindo...");
                break;

            case 1:
                Console.Clear();
                Console.WriteLine("Nome do cliente:");
                string name = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Email:");
                string email = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Telefone:");
                string cellphone = Console.ReadLine() ?? string.Empty;

                if (CreateCustomer(name, email, cellphone))
                {
                    Console.WriteLine("✅ Cliente criado com sucesso!");
                    Access access = new Access();
                    access.AccessGranted();
                }
                else
                {
                    Console.WriteLine("❌ Cliente já existente!");
                }

                break;

            case 2:
                Console.Clear();
                Console.WriteLine("LISTA DE CLIENTES");
                Console.WriteLine("▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁");

                foreach (var c in customerList)
                {
                    Console.WriteLine($"\nID: {c.Id} | Nome: {c.Name} | Email: {c.Email} | Telefone: {c.Cellphone}");
                }
                    Console.WriteLine("\nAperte ENTER para voltar ao MENU");
                    Console.ReadLine();
                    Console.Clear();
                    CustomerList();
                break;

            case 3:
                Console.WriteLine("Função de atualização ainda não implementada.");
                break;

            case 4:
                Console.WriteLine("Função de exclusão ainda não implementada.");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
