public class Cliente
{
    private string _nome;
    private Endereco _endereco;

    public Cliente(string nome, Endereco endereco)
    {
        _nome = nome;
        _endereco = endereco;
    }

    public string Nome { get { return _nome; } }
    public Endereco Endereco { get { return _endereco; } }

    // Diz se o cliente mora nos EUA (chama o método do Endereco)
    public bool MoraNosEUA()
    {
        return _endereco.EhNosEUA();
    }
}