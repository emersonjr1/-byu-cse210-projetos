
public class TarefadeMatematica : Tarefa {
 
    private string _capitulo;
    private string _problemas;

    public TarefadeMatematica(string nome, string topico, string capitulo, string problemas) : base(nome, topico) 
    {
        _capitulo = capitulo;
        _problemas = problemas;
        
    }

    //-------------


    public string ObterListaDeTarefas()
    {
        return $"Capitulo {_capitulo} Problemas {_problemas}";
    }
    
    
}