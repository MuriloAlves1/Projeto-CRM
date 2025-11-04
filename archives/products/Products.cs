internal class Products
{
    public void ProductsList()
    {
        Console.WriteLine("PRODUTOS");
        Console.WriteLine("▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁");
        Console.WriteLine("1. Cadastrar produto");
        Console.WriteLine("2. Listar produto");
        Console.WriteLine("3. Atualizar produto");
        Console.WriteLine("4. Excluir produto");
        Console.WriteLine("0. Sair");
        int options = Convert.ToInt32(Console.ReadLine()); 
    }
}