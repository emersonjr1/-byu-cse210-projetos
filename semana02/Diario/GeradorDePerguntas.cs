using System;
using System.IO;

public class GeradorDePerguntas
{
    public List<string> _perguntas = new List<string>();


    public string ObterPerguntaAleatoria()
    {
        string[] linhas = File.ReadAllLines("perguntas.csv");
        for (int i=1; i<linhas.Length; i++)
        {
            _perguntas.Add(linhas[i]);
        }

        Random random = new Random();
        int perguntaEscolhida = random.Next(_perguntas.Count);

        return _perguntas[perguntaEscolhida];
    }
}
