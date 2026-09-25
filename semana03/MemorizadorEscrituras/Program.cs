using System;

class Program
{
    static void Main(string[] args)
    {
       Referencia referencia = new Referencia("Provérbios", 3, 5, 6);
        string texto = "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento";

        Escritura escritura = new Escritura(referencia, texto);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();

            if (escritura.EstaCompletamenteOculta())
            {
                Console.WriteLine("Parabéns! Todas as palavras foram ocultadas.");
                break;
            }

            Console.WriteLine("Pressione ENTER para ocultar palavras ou digite 'sair' para encerrar:");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);
        
        }
    }
}