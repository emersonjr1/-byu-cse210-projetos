using System;

class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _ultimoVersiculo;

    public Referencia(string livro, int capitulo, int versiculo)
    {
        Console.WriteLine("Digite o Livro");
        
        _livro = livro;
        
        _capitulo = capitulo;
        
        _versiculo = versiculo;
        
    }

    public Referencia(string livro, int capitulo, int primeiroVersiculo, int ultimoVersiculo)
    {
       
        _livro = livro;
        
        _capitulo = capitulo;

        _versiculo = primeiroVersiculo;
        
        _ultimoVersiculo = ultimoVersiculo;
    }

    public string ObterTexto()
    {
        
        if (_ultimoVersiculo > 0)
        {
            return $"Livro {_livro} {_capitulo}:{_versiculo}-{_ultimoVersiculo}";
        }
        else
        {
            return $"Livro {_livro} {_capitulo}:{_versiculo}";
        }

    }


}