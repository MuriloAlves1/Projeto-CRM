internal class Access
{
    public void AccessGranted()
    {
        Console.Clear();
        Console.WriteLine("Acesso realizado com sucesso!");
        Console.WriteLine("▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁");
        Console.WriteLine("Selecione uma das opções");
        Console.WriteLine("1. Clientes");
        Console.WriteLine("2. Produtos");
        Console.WriteLine("3. Sair");
        int options = Convert.ToInt32(Console.ReadLine());

        //OPTIONS
        switch (options)
        {
            case 1:
                Console.Clear();
                CustomerManager customer = new CustomerManager();
                customer.CustomerList();
                break;

            case 2:
                Console.Clear();
                Products products = new Products();
                products.ProductsList();
                break;

            case 3:
                Console.Clear();
                break;

            default:
                Console.WriteLine("Opção invalida");
                break;
        }
            
    }
}