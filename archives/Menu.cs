internal class Menu()
{

    public void MenuStart()
    {
        UserManager userManager = new UserManager();
        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine("┌─────────────────┐");
            Console.WriteLine("|       CRM       |");
            Console.WriteLine("└─────────────────┘");

            Console.WriteLine("Para acessar a conta realize o Login ou crie uma conta");
            Console.WriteLine("1. Realizar Login");
            Console.WriteLine("2. Criar Conta");

            int LoginOrRegister = Convert.ToInt32(Console.ReadLine());

            switch (LoginOrRegister)
            {
                case 1:
                    Console.WriteLine("Digite seu login");
                    string login = Console.ReadLine() ?? string.Empty;;
                    Console.WriteLine("Digite seu senha");
                    string password = Console.ReadLine() ?? string.Empty;;
                    if (userManager.Login(login, password))
                    {
                        Console.WriteLine("✅ Login realizado com sucesso!");
                        Access access = new Access();
                        access.AccessGranted();
                    }
                    else
                    {
                        Console.WriteLine("❌ Login ou senha incorretos!");
                    }
                    break;

                case 2:
                    Console.WriteLine("Digite um login "); 
                    string newLogin = Console.ReadLine() ?? string.Empty;;
                    Console.WriteLine("Digite uma senha ");
                    string newPassword = Console.ReadLine() ?? string.Empty;;

                    if (userManager.CreateAccount(newLogin, newPassword))
                        Console.WriteLine("✅ Conta criada com sucesso!");
                    else
                        Console.WriteLine("⚠️ Esse login já existe!");

                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    Console.WriteLine("Aperte ENTER para voltar ao Menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}