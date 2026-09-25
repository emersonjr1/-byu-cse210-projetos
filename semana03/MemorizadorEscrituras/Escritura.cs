using System;
using System.Collections.Generic;

public class Escritura
{
    public Referencia _referencia;
    private List<Palavra> _palavras = new List<Palavra>();

    public Escritura(Referencia referencia, string texto)
    {   
        _referencia = referencia;

        string[] palavrasArray = texto.Split(" ");

        foreach (string palavra in palavrasArray)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        Random random = new Random();

        List<Palavra> palavrasVisiveis = new List<Palavra>();
      
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                palavrasVisiveis.Add(palavra);
            }
        }

        // 2. Sorteia e oculta a quantidade solicitada
        for (int i = 0; i < numeroParaOcultar; i++)
        {
            if (palavrasVisiveis.Count == 0)
            {
                break; // Se não houver mais palavras visíveis, para o loop
            }

            int indiceSorteado = random.Next(palavrasVisiveis.Count);
            palavrasVisiveis[indiceSorteado].Ocultar();
            palavrasVisiveis.RemoveAt(indiceSorteado); // Remove para não repetir o sorteio
        }
    }

    public string ObterTexto()
    {
        List<string> palavrasFormatadas = new List<string>();

        foreach (Palavra p in _palavras)
        {
            palavrasFormatadas.Add(p.ObterTexto());
        }

        string textoUnido = string.Join(" ", palavrasFormatadas);
        return $"{_referencia.ObterTexto()} - {textoUnido}";
    }

    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra p in _palavras)
        {
            if (!p.EstaOculta())
            {
                return false; // Se encontrar ao menos uma palavra visível, retorna false
            }
        }
        return true; // Se todas estiverem ocultas, retorna true
    }
}