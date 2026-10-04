public class TarefaDeRedacao : Tarefa
{
 
    private string _titulo;
    
    //-------------
    
    public TarefaDeRedacao(string nome, string topico, string titulo) : base(nome, topico)
    {
        _titulo = titulo;


    }

    //-------------
    
    public string ObterInformacoesRedacao()
    {
        return $"Titulo {_titulo}, Por {_nomeEstudante}";
    }

}