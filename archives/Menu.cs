internal class Menu()
{

    public void MenuStart()
    {
    
    while(true){
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
                string login = Console.ReadLine();
                Console.WriteLine("Digite seu senha");
                    string password = Console.ReadLine();
                    Access access = new Access();
                    access.AccessGranted();
                return;

            case 2:
                Console.WriteLine("Digite um login ");
                string newLogin = Console.ReadLine();
                Console.WriteLine("Digite uma senha ");
                string newPassword = Console.ReadLine();
                Console.WriteLine("Conta criada com sucesso!");
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