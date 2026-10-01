public class Produto
{
    private string _nome;
    private string _id;
    private decimal _preco;
    private int _quantidade;

    public Produto(string nome, string id, decimal preco, int quantidade)
    {
        _nome = nome;
        _id = id;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string Nome { get { return _nome; } }
    public string Id { get { return _id; } }
    public decimal Preco { get { return _preco; } }
    public int Quantidade { get { return _quantidade; } }

    // Custo total do produto = preço × quantidade
    public decimal CustoTotal()
    {
        return _preco * _quantidade;
    }
}