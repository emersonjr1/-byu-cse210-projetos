 

using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        Tarefa t1 = new Tarefa("Samuel Bennett", "Multiplicação");
        Console.WriteLine(t1.ObterResumo());

    //------------- APENAS PARA TRACOS 
        void Tracos()
        {
            Console.WriteLine(new String('-', 12));
        }

        Tracos();

    //-------------
    
        TarefadeMatematica t2 = new TarefadeMatematica("Emerson", "Dados", "7.3", "8-19");

        Console.WriteLine(t2.ObterResumo());
        Console.WriteLine(t2.ObterListaDeTarefas());

        Tracos();

    //-------------
    
        TarefaDeRedacao t3 = new TarefaDeRedacao("Joao", "Moby Dick", "Historias antigas sobre o Mar");
        Console.WriteLine(t3.ObterResumo());
        Console.WriteLine(t3.ObterInformacoesRedacao());
    
    //-------------
    
    
    }
}