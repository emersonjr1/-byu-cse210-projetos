 
public class Tarefa
{
    protected string _nomeEstudante;
    private string _topico;

    //-------------


    public Tarefa(string nome, string topico)
    {
        _nomeEstudante = nome;
        _topico = topico;
    }
    
    //-------------
    
    public string ObterResumo()
    {
        return $"{_nomeEstudante} - {_topico}";
    }
}