using System;

class Program
{
    static void Main(string[] args)
    {
        Fracao f1 = new Fracao();
        Console.WriteLine(f1.obterFracaoEmTexto());
        Console.WriteLine(f1.obterFracaoDecimal());
        
        Fracao f2 = new Fracao(5);
        Console.WriteLine(f2.obterFracaoEmTexto());
        Console.WriteLine(f2.obterFracaoDecimal());

        Fracao f3 = new Fracao(5,3);
        Console.WriteLine(f3.obterFracaoEmTexto());
        Console.WriteLine(f3.obterFracaoDecimal());

    }
}