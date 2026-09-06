using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual a nota numérica ");
        int nota = int.Parse(Console.ReadLine());

        if (nota >= 90){

            string conceito = "A";
            Console.Write($"Sua é {conceito}; ");
        } else if (nota >= 80 && nota < 90 ){
            string conceito = "B";
            Console.Write($"Sua nota {conceito}");
        } else if (nota >=70 && nota < 80){
            string conceito = "C";
            Console.Write($"Sua nota é {conceito}");
        }else if (nota >= 60 && nota < 70){
            string conceito = "D";
            Console.Write($"Sua nota é ${conceito}");
        }else
        {
            string conceito = "F";
            Console.Write($"Sua nota é {conceito}");
        }

    }
}