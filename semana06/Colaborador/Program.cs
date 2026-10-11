using System;

namespace colaborador{
    class Program
    {
        static void Main(string[] args)
        {
            Horista horista = new Horista();
            horista.DefinirNome("Jõao");
            horista.DefinirID("123abc");
            horista.DefinirValorHora(10);
            horista.DefinirHorasTrabalhadas(35);


            Mensalista mensalista = new Mensalista();
            mensalista.DefinirNome("Pedro");
            mensalista.DefinirID("456def");
            mensalista.DefinirSalarioMensal(5000);
            
            // ExibirInformacoesColaborador(horista);
            // ExibirInformacoesColaborador(mensalista);

            List<Colaborador> colaboradores = new List<Colaborador>();

            colaboradores.Add(horista);
            colaboradores.Add(mensalista);

            foreach (Colaborador c in colaboradores)
            {
                ExibirInformacoesColaborador(c);
            }
   
        }


        public static void ExibirInformacoesColaborador(Colaborador colaborador)
        {
            Console.WriteLine($"{colaborador.ObterNome()} - {colaborador.ObterId()} - Pagamento: {colaborador.Pagamento()}") ;   
        }
    }
}