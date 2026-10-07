namespace Introspeccao;

// 1. CLASSE PAI (Atividade)
public class Atividade
{
    protected string _nome;
    protected string _descricao;
    protected int _duracao;

    public Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = 0; // A duração é definida dinamicamente pelo usuário no método ExibirMensagemInicial
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"Bem-vindo à {_nome}.\n");
        Console.WriteLine(_descricao);
        Console.WriteLine();

        Console.Write("Quanto tempo, em segundos, você gostaria para sua sessão? ");
        _duracao = int.Parse(Console.ReadLine() ?? "0");

        Console.Clear();
        Console.WriteLine("Prepare-se...");
        ExibirProgresso(5);
        Console.WriteLine();
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine();
        Console.WriteLine("Mandou bem!!");
        ExibirProgresso(3);
        
        Console.WriteLine($"\nVocê concluiu mais {_duracao} segundos da atividade {_nome}.");
        ExibirProgresso(5);
    }

    public void ExibirProgresso(int segundos)
    {
        List<string> simbolos = new List<string>
        {
            "|", "/", "-", @"\", "|", "/", "-", @"\"
        };

        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(segundos);
        
        int i = 0;
        while (DateTime.Now < horaFim)
        {
            string s = simbolos[i];
            Console.Write(s);

            Thread.Sleep(250); // 250ms garante uma animação fluida (4 trocas por segundo)
            Console.Write("\b \b");

            i++;
            if (i >= simbolos.Count)
            {
                i = 0;
            }
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Aguarda exatamente 1 segundo por número
            Console.Write("\b \b");
        }
    }
}