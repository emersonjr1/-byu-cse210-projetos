using System;

class Program
{
    static void Main(string[] args)
    {
        Random geradorAleatorio = new Random();
        int numero = geradorAleatorio.Next(0, 101);
        int intNum;
        
        do
        {
            
        Console.Write("Descubra o numero que escolhi entre 0 e 100. Digite um numero: ");
        string respNum = Console.ReadLine();
        intNum = int.Parse(respNum);

        if (intNum < numero)
            {
                Console.Write("O numero correto é MAIOR. \n");
            }
        else if (intNum > numero)
            {
              Console.WriteLine("O número correto é MENOR.\n");  
            }
        } while (intNum != numero);
        
        Console.WriteLine("Parabéns! Você acertou o numero!");
    }
}