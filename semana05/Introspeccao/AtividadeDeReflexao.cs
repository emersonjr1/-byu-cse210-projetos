using System;
using System.Collections.Generic;

namespace Introspeccao;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;

    public AtividadeDeReflexao() 
        : base("Atividade de Reflexão", 
               "Esta atividade ajudará você a refletir sobre momentos da sua vida em que você demonstrou força e resiliência. Isso ajudará você a reconhecer o poder que você tem e como pode usá-lo em outros aspectos da sua vida.")
    {
        _reflexoes = new List<string>
        {
            "Pense em uma vez em que você defendeu outra pessoa.",
            "Pense em uma vez em que você fez algo realmente difícil.",
            "Pense em uma vez em que você ajudou alguém necessitado.",
            "Pense em uma vez em que você fez algo verdadeiramente altruísta."
        };

        _perguntas = new List<string>
        {
            "Por que essa experiência foi marcante para você?",
            "Como você se sentiu quando o momento terminou?",
            "O que tornou esse momento diferente de outros momentos?",
            "O que você aprendeu sobre si mesmo através dessa experiência?",
            "Como você começou?",
            "O que você pode aprender com essa experiência que se aplica a outras situações?"
        };
    }

    public void Executar()
    {
        // 1. Mensagem inicial (exibe nome, descrição e pede a duração em segundos)
        ExibirMensagemInicial();

        // 2. Apresenta o prompt principal de reflexão
        Console.WriteLine("Considere a seguinte instrução:\n");
        Console.WriteLine($"--- {ObterReflexaoAleatoria()} ---");
        Console.WriteLine("\nQuando você tiver algo em mente, pressione ENTER para continuar.");
        Console.ReadLine();

        Console.WriteLine("Agora reflita sobre cada uma das seguintes perguntas relacionadas a essa experiência.");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.Clear();

        // 3. Loop de perguntas que roda durante o tempo definido pelo usuário (_duracao)
        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(_duracao);

        while (DateTime.Now < horaFim)
        {
            Console.Write($"> {ObterPerguntaAleatoria()} ");
            ExibirProgresso(10); // Exibe o spinner por 10 segundos a cada pergunta
            Console.WriteLine();
        }

        // 4. Mensagem final
        ExibirMensagemFinal();
    }

    public string ObterReflexaoAleatoria()
    {
        Random random = new Random();
        int index = random.Next(_reflexoes.Count);
        return _reflexoes[index];
    }

    public string ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        return _perguntas[index];
    }
}