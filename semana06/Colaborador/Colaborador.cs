public abstract class Colaborador
{
    private string _nome;
    private string _id;

    public string ObterNome()
    {
        return _nome;
    }

    public void DefinirNome(string nome)
    {
        _nome = nome;
    }

    public string ObterId()
    {
        return _id;
    }

    public void DefinirID(string id)
    {

        _id = id;

    }

    public abstract float Pagamento();
 

}