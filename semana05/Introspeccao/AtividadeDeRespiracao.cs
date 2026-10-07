namespace Introspeccao;

// 1. Herda da classe base Atividade
public class AtividadeDeRespiracao : Atividade
{
    // 2. Construtor repassa o nome e a descrição padrão para o construtor base
    public AtividadeDeRespiracao() 
        : base("Atividade de Respiração", 
               "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente. Limpe sua mente e concentre-se na sua respiração.")
    {
    }

    public void Executar()
    {
        // Mensagem inicial (apresenta nome, descrição, solicita a duração e faz a pausa de "Prepare-se...")
        ExibirMensagemInicial();

        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(_duracao);

        // Ciclo de respiração executado até atingir o tempo total (_duracao)
        while (DateTime.Now < horaFim)
        {
            Console.Write("Inspire...");
            ExibirContagemRegressiva(4); // 4 segundos para inspirar
            Console.WriteLine();

            Console.Write("Expire...");
            ExibirContagemRegressiva(6); // 6 segundos para expirar
            Console.WriteLine("\n");
        }

        // Mensagem final de encerramento
        ExibirMensagemFinal();
    }
}