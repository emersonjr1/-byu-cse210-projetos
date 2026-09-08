using System;

class Program
{
    static void Main(string[] args)
    {
        static void ExibirBoasVindas(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        static string PerguntarNomeUsuario(string mensagem)
        {
            Console.WriteLine(mensagem);
            string nome = Console.ReadLine();
            return nome;
        }

        static int PerguntarNumeroFavorito(string mensagem)
        {
            Console.WriteLine(mensagem);
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
        
        static int ElevarAoQuadrado(int numero, int expoencial)
        {
            
            int quadrado = (int)Math.Pow(numero, expoencial);
            // OR numeo * numero
            return quadrado;
        }

        static void ExibirResultado(string nome, int quadrado)
        {
            Console.WriteLine($"{nome}, o quadrado do seu numero é {quadrado}");
        }

        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio5.");
        ExibirBoasVindas("Bem vindo ao programa de cálculo.");
        string nome = PerguntarNomeUsuario("Qual seu nome de usuario?");
        int numero = PerguntarNumeroFavorito("Qual seu numero favorito?");
        int quadrado = ElevarAoQuadrado(numero,2);
        ExibirResultado(nome,quadrado);
        
    }
}