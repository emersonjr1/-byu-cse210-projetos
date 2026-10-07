namespace Introspeccao;


public class AtividadeDeListagem : Atividade
{
    private int _contador; // Declarado o campo _contador
    private List<string> _perguntas;

    // 2. Repassa o nome e a descrição para o construtor pai
    public AtividadeDeListagem() 
        : base("Atividade de Listagem", 
               "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área.")
    {
        _contador = 0;
        _perguntas = new List<string>
        {
            "Quem são as pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu o Espírito Santo neste mês?",
            "Quem são alguns dos seus heróis pessoais?"
        };
    }

public void Executar()
{
    ExibirMensagemInicial();

    Console.WriteLine("\nPense na seguinte pergunta:");
    Console.WriteLine($"--- {ObterPerguntaAleatoria()} ---");
    
    Console.Write("Você pode começar em: ");
    ExibirContagemRegressiva(5);
    Console.WriteLine();

    List<string> itens = ObterListaDoUsuario();
    _contador = itens.Count; // Atribui o total de itens

    // Use _contador aqui em vez de itens.Count!
    Console.WriteLine($"\nVocê listou {_contador} itens!");

    ExibirMensagemFinal();
}

    public string ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        return _perguntas[index];
    }

    public List<string> ObterListaDoUsuario()
    {
        List<string> listaUser = new List<string>();
        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(_duracao);

        while (DateTime.Now < horaFim)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                listaUser.Add(item);
            }
        }

        return listaUser;
    }
}