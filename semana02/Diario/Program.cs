using System;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

        Diario diario = new Diario();
        GeradorDePerguntas gerarPerguntas = new GeradorDePerguntas();
        do
        {

        DateTime hotaAtual = DateTime.Now;
        string dataHoje = hotaAtual.ToShortDateString();

        Console.WriteLine("Bem Vindo ao Programa Diário!");
        Console.WriteLine("Por favor seleciona uma das seguintes opções: ");

        //Opções
        Console.WriteLine("1. Escrever \n2. Exibir \n3. Carregar \n4. Salvar \n5. Sair");
        
        //Pergunta e repsosta
        Console.Write("O que voce gostaria de fazer? ");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
            {
                case 1:

                    Registro registro = new Registro();
                    registro._data = dataHoje;
                    registro._textoPergunta = gerarPerguntas.ObterPerguntaAleatoria();
                    
                    Console.WriteLine($"\nPergunta: {registro._textoPergunta}");
                    Console.Write("Sua resposta: ");
                    registro._textoResposta = Console.ReadLine();

                    string registroCriado = $"{registro._data} - {registro._textoPergunta} - {registro._textoResposta}";
                    diario._registros.Add(registroCriado); 

                    Console.WriteLine("Registro adicionado com sucesso!");
                    break;

                case 2:
                    
                    Console.WriteLine("\n--- Exibindo todos os registros ---");
                    diario.ExibirTodos();
                    
                    break;
                
                case 3:
                    Console.Write("\nDigite o nome do arquivo para carregar (ex: diario.txt): ");
                    string arqCarregar = Console.ReadLine();
                    string mensagemCarg = diario.CarregarDoArquivo(arqCarregar);
                    Console.WriteLine(mensagemCarg);
                    break;

                case 4:
                    Console.Write("\nDigite o nome do arquivo para salvar (ex: diario.txt): ");
                    string arqSalvar = Console.ReadLine();
                    string mensagemSalvar = diario.SalvarNoArquivo(arqSalvar);
                    Console.WriteLine(mensagemSalvar);
                    break;


                case 5:
                    Console.WriteLine("\nSaindo... Obrigado por usar o Diário!");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;

            }

        }
        
        while (opcao != 5);
    
    }
}