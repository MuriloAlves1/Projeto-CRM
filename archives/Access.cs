internal class Access
{
    public void AccessGranted()
    {
        Console.Clear();
        Console.WriteLine("Acesso realizado com sucesso!");
        Console.WriteLine("▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁");
        Console.WriteLine("Selecione uma das opções");
        Console.WriteLine("1. Resumo");
        Console.WriteLine("2. Clientes");
        Console.WriteLine("3. Funil");
        Console.WriteLine("4. Sair");
        int options = Convert.ToInt32(Console.ReadLine());
    
    //OPTIONS
    switch(options)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("〖 RESUMO 〗");
                
                
                break;
        }
    }
}