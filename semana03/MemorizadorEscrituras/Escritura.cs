using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras = new List<Palavra>();

    public Escrituras(Referencia referencia, string texto)
    {
        _referencia = referencia;

        string[] palavrasArray = texto.Split(' ');
        foreach (string p in palavrasArray)
        {
            _palavras.Add(new Palavra(p));
        }
    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        Random random = new Random();
        List<Palavra> palavrasVisiveis = new List<Palavra>();

        // 1. Filtra apenas as palavras que ainda não estão ocultas
        foreach (Palavra p in _palavras)
        {
            if (!p.EstaOculta())
            {
                palavrasVisiveis.Add(p);
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