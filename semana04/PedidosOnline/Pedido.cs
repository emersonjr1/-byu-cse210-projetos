using System.Collections.Generic;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public Cliente Cliente { get { return _cliente; } }
    public List<Produto> Produtos { get { return _produtos; } }

    // Adicionar produto ao pedido
    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    // Calcula o custo de envio
    private decimal CustoEnvio()
    {
        if (_cliente.MoraNosEUA())
            return 5m;   // 5 dólares
        else
            return 35m;  // 35 dólares
    }

    // Calcula o total: soma dos produtos + envio
    public decimal CalcularTotal()
    {
        decimal totalProdutos = 0;
        foreach (Produto p in _produtos)
        {
            totalProdutos = totalProdutos + p.CustoTotal();
        }
        return totalProdutos + CustoEnvio();
    }

    // Etiqueta de embalagem: nome + ID de cada produto
    public string EtiquetaEmbalagem()
    {
        string resultado = "--- ETIQUETA DE EMBALAGEM ---\n";
        foreach (Produto p in _produtos)
        {
            resultado = resultado + "Produto: " + p.Nome + " | ID: " + p.Id + "\n";
        }
        return resultado;
    }

    // Etiqueta de envio: nome + endereço do cliente
    public string EtiquetaEnvio()
    {
        return "--- ETIQUETA DE ENVIO ---\n" +
               _cliente.Nome + "\n" +
               _cliente.Endereco.EnderecoCompleto();
    }
}