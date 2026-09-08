using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio4.");

        Console.WriteLine("\n Insira uma lista de números negativos ou positivos; E digite 0 quando terminar.");
        List<int> numeros = new List<int>();

        while (true)
        {
            Console.WriteLine("Digite um numero: ");
            string entrada = Console.ReadLine();
            int num = int.Parse(entrada);

            if (num == 0)
            {
                break;
            }

            numeros.Add(num);
        }

        int soma = numeros.Sum();
        int maior = numeros.Max();
        double media = (double)soma / numeros.Count;
        
        Console.Write($"\nA soma é: {soma} ");
        Console.Write($"\nA média é: {media}");
        Console.Write($"\nO maior numero é: {maior}");
        
    }
}