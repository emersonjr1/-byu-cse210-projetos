using System;

class Program
{
    static void Main(string[] args)
    {
        Emprego emprego1 = new Emprego
        {
            _cargo = "Engenheiro de Software",
            _empresa = "Microsoft",
            _anoInicio = "2002",
            _anoFim = "2010"
        };

        emprego1.Exibir();

        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._name = "Emerson M Junior";
        meuCurriculo._empregos.Add(emprego1);

        meuCurriculo.MostrarEmpregos();
        
    }
}