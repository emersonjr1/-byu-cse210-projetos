public class Endereco
{
    // Atributos PRIVADOS (encapsulamento!)
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    // Construtor: define os valores quando criamos o objeto
    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    // Getters (para poder LER os valores de fora)
    public string Rua { get { return _rua; } }
    public string Cidade { get { return _cidade; } }
    public string Estado { get { return _estado; } }
    public string Pais { get { return _pais; } }

    // Método: diz se o endereço é nos EUA
    public bool EhNosEUA()
    {
        return _pais.ToLower() == "eua" || _pais.ToLower() == "usa" 
               || _pais.ToLower() == "estados unidos";
    }

    // Método: retorna o endereço todo formatado
    public string EnderecoCompleto()
    {
        return _rua + "\n" + _cidade + ", " + _estado + "\n" + _pais;
    }
}