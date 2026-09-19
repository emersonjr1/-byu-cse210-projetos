using System;

class Fracao
{
    private int _numerador;
    private int _denominador;

    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    public Fracao(int numeroInteio)
    {
        _numerador = numeroInteio;
        _denominador = 1;
        
    }

    public Fracao(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;

    }

    public string obterFracaoEmTexto()
    {
        string texto = $"{_numerador}/{_denominador}";
        return texto;
    }

    public double obterFracaoDecimal()
    {
        return (double)_numerador / (double)_denominador;
    }
}