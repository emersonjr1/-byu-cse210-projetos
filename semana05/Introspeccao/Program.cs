using System;

namespace Introspeccao;

class Program
{
    static void Main(string[] args)
    {
        string opcao = "";

        while (opcao != "4")
        {
            Console.Clear();
            Console.WriteLine("Opções de Menu:");
            Console.WriteLine("  1. Iniciar atividade de respiração");
            Console.WriteLine("  2. Iniciar atividade de reflexão");
            Console.WriteLine("  3. Iniciar atividade de listagem");
            Console.WriteLine("  4. Sair");
            Console.Write("Selecione uma opção do menu: ");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AtividadeDeRespiracao respiracao = new AtividadeDeRespiracao();
                    respiracao.Executar();
                    break;

                case "2":
                    AtividadeDeReflexao reflexao = new AtividadeDeReflexao();
                    reflexao.Executar();
                    break;

                case "3":
                    AtividadeDeListagem listagem = new AtividadeDeListagem();
                    listagem.Executar();
                    break;

                case "4":
                    Console.WriteLine("\nObrigado por usar o Programa de Introspecção! Até logo.");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida. Pressione ENTER para tentar novamente.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}