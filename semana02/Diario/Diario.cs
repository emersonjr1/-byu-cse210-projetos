using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{


    public List<string> _registros = new List<string>();


    public void AdicionarRegistro(string novoRegistro)
        {   
            DateTime horaAtual = DateTime.Now;
            string dataTexto = horaAtual.ToShortDateString();
           
            _registros.Add($"{dataTexto} - {novoRegistro}");
        }


    public void ExibirTodos()
        {
            foreach (string linha in _registros)
            {
                Console.WriteLine(linha);
            }
        }


    // Precisa de return
    public string SalvarNoArquivo(string arquivo)
        {
            string nomeDoArquivo = arquivo;
            using (StreamWriter arquivoSaida = new StreamWriter(nomeDoArquivo))
                
            {
                //Voce pode adicionar texto ao arquivo como método WriteLine
                foreach (string linha in _registros)
                {
                    arquivoSaida.WriteLine($"{linha},");
                }

            }

            return $"Registros salvos com sucesso '{arquivo}'";
        }


    // Precisa de return
    public string CarregarDoArquivo(string arquivo)
        {
            string nomeDoArquivo = arquivo;
            string[] linhas = System.IO.File.ReadAllLines(nomeDoArquivo);

            _registros.Clear();
            
            foreach(string linha in linhas)
            {
                _registros.Add(linha);
            }


            return "Arquivo carregado com sucesso.";        
        }

}