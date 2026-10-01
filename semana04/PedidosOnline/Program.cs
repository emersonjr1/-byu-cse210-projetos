using System;

public class Program
{
    public static void Main()
    {
        // ===== PEDIDO 1: Cliente nos EUA =====
        Endereco end1 = new Endereco("123 Main St", "Salt Lake City", "UT", "EUA");
        Cliente cliente1 = new Cliente("João Silva", end1);

        Pedido pedido1 = new Pedido(cliente1);
        pedido1.AdicionarProduto(new Produto("Notebook", "P001", 3500.00m, 1));
        pedido1.AdicionarProduto(new Produto("Mouse", "P002", 150.00m, 2));
        pedido1.AdicionarProduto(new Produto("Teclado", "P003", 250.00m, 1));

        Console.WriteLine("========== PEDIDO 1 ==========");
        Console.WriteLine(pedido1.EtiquetaEmbalagem());
        Console.WriteLine(pedido1.EtiquetaEnvio());
        Console.WriteLine("Total do pedido: $" + pedido1.CalcularTotal());
        Console.WriteLine();

        // ===== PEDIDO 2: Cliente fora dos EUA =====
        Endereco end2 = new Endereco("Av. Paulista 1000", "São Paulo", "SP", "Brasil");
        Cliente cliente2 = new Cliente("Maria Santos", end2);

        Pedido pedido2 = new Pedido(cliente2);
        pedido2.AdicionarProduto(new Produto("Fone Bluetooth", "P010", 300.00m, 1));
        pedido2.AdicionarProduto(new Produto("Carregador", "P011", 80.00m, 2));

        Console.WriteLine("========== PEDIDO 2 ==========");
        Console.WriteLine(pedido2.EtiquetaEmbalagem());
        Console.WriteLine(pedido2.EtiquetaEnvio());
        Console.WriteLine("Total do pedido: $" + pedido2.CalcularTotal());
    }
}