using System;
using System.Collections.Generic;
using System.IO;

public class GerenciadorDeMetas
{
    private List<Meta> _metas;
    private int _pontos;

    public GerenciadorDeMetas()
    {
        _metas = new List<Meta>();
        _pontos = 0;
    }

    public void Iniciar()
    {
        int escolha = 0;

        // Alterado de 6 para 7 para que o loop encerre quando o usuário escolher sair
        while (escolha != 7)
        {
            Console.Clear();
            ExibirInfoJogador();
            
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Criar Nova Meta");
            Console.WriteLine("2. Listar Nomes das Metas");
            Console.WriteLine("3. Listar Detalhes das Metas");
            Console.WriteLine("4. Registrar Evento");
            Console.WriteLine("5. Salvar Metas");
            Console.WriteLine("6. Carregar Metas");
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out escolha))
            {
                switch (escolha)
                {
                    case 1:
                        CriarMeta();
                        break;
                    case 2:
                        ListarNomesDasMetas();
                        break;
                    case 3:
                        ListarDetalhesDasMetas();
                        break;
                    case 4:
                        RegistrarEvento();
                        break;
                    case 5:
                        SalvarMetas();
                        break;
                    case 6:
                        CarregarMetas();
                        break;
                    case 7:
                        Console.WriteLine("\nEncerrando o programa. Até mais!");
                        break;
                }

                if (escolha != 7)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }

    public void ExibirInfoJogador()
    {
        Console.WriteLine($"\nVocê tem {_pontos} pontos.");
    }

    public void ListarNomesDasMetas()
    {
        Console.WriteLine("\n--- Metas Cadastradas ---");
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterRepresentacaoEmTexto()}");
        }
    }

    public void ListarDetalhesDasMetas()
    {
        Console.WriteLine("\n--- Detalhes das Metas ---");
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhesEmTexto()}");
        }
    }

    public void CriarMeta()
    {
        Console.WriteLine("\nTipos de Metas:");
        Console.WriteLine("1. Meta Simples");
        Console.WriteLine("2. Meta Eterna");
        Console.WriteLine("3. Meta de Lista de Tarefas (Checklist)");
        Console.Write("Escolha o tipo de meta que deseja criar: ");
        string tipo = Console.ReadLine();

        Console.Write("Digite o nome da meta: ");
        string nome = Console.ReadLine();
        Console.Write("Digite a descrição da meta: ");
        string descricao = Console.ReadLine();
        
        Console.Write("Digite a quantidade de pontos: ");
        int pontos = int.Parse(Console.ReadLine()); // Convertido para int para evitar incompatibilidade

        if (tipo == "1")
        {
            MetaSimples novaMeta = new MetaSimples(nome, descricao, pontos);
            _metas.Add(novaMeta);
        }
        else if (tipo == "2")
        {
            MetaEterna novaMeta = new MetaEterna(nome, descricao, pontos);
            _metas.Add(novaMeta);
        }
        else if (tipo == "3")
        {
            Console.Write("Digite o número total de vezes necessárias: ");
            int total = int.Parse(Console.ReadLine());
            Console.Write("Digite os pontos de bônus ao concluir: ");
            int bonus = int.Parse(Console.ReadLine());

            MetaDeListaDeTarefas novaMeta = new MetaDeListaDeTarefas(nome, descricao, pontos, total, bonus);
            _metas.Add(novaMeta);
        }

        Console.WriteLine("Meta criada com sucesso!");
    }

    public void RegistrarEvento()
    {
        ListarNomesDasMetas();
        Console.Write("Qual meta você deseja registrar como realizada? ");
        int indice = int.Parse(Console.ReadLine()) - 1;

        if (indice >= 0 && indice < _metas.Count)
        {
            Meta metaSelecionada = _metas[indice];
            metaSelecionada.RegistrarEvento();
            
            Console.WriteLine("Parabéns! Evento registrado.");
        }
        else
        {
            Console.WriteLine("Índice inválido.");
        }
    }

    public void SalvarMetas()
    {
        Console.Write("Digite o nome do arquivo para salvar (ex: metas.txt): ");
        string arquivo = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(arquivo))
        {
            writer.WriteLine(_pontos);

            foreach (Meta meta in _metas)
            {
                writer.WriteLine(meta.ObterRepresentacaoEmTexto());
            }
        }

        Console.WriteLine("Progresso salvo com sucesso no arquivo .txt!");
    }

    public void CarregarMetas()
    {
        Console.Write("Digite o nome do arquivo para carregar (ex: metas.txt): ");
        string arquivo = Console.ReadLine();

        if (File.Exists(arquivo))
        {
            string[] linhas = File.ReadAllLines(arquivo);
            
            _pontos = int.Parse(linhas[0]);
            _metas.Clear();

            for (int i = 1; i < linhas.Length; i++)
            {
                string linha = linhas[i];
                string[] partes = linha.Split(':');
                string tipoMeta = partes[0];
                string[] dados = partes[1].Split(',');

                if (tipoMeta == "MetaSimples")
                {
                    string nome = dados[0];
                    string descricao = dados[1];
                    int pontos = int.Parse(dados[2]);
                    bool concluida = bool.Parse(dados[3]);

                    MetaSimples meta = new MetaSimples(nome, descricao, pontos);
                    if (concluida) meta.RegistrarEvento();
                    _metas.Add(meta);
                }
                else if (tipoMeta == "MetaEterna")
                {
                    string nome = dados[0];
                    string descricao = dados[1];
                    int pontos = int.Parse(dados[2]);

                    MetaEterna meta = new MetaEterna(nome, descricao, pontos);
                    _metas.Add(meta);
                }
                else if (tipoMeta == "MetaDeListaDeTarefas")
                {
                    string nome = dados[0];
                    string descricao = dados[1];
                    int pontos = int.Parse(dados[2]);
                    int bonus = int.Parse(dados[3]);
                    int total = int.Parse(dados[4]);
                    int concluidas = int.Parse(dados[5]);

                    MetaDeListaDeTarefas meta = new MetaDeListaDeTarefas(nome, descricao, pontos, total, bonus);
                    for (int c = 0; c < concluidas; c++)
                    {
                        meta.RegistrarEvento();
                    }
                    _metas.Add(meta);
                }
            }

            Console.WriteLine("Metas carregadas com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }
}