using System;

class Program
{
    static void Main(string[] args)
    {
       List<Figura> figuras = new List<Figura>(); 

       Quadrado quadrado1 = new Quadrado("azul",2);
       figuras.Add(quadrado1);

       Retangulo retangulo1 = new Retangulo("verde",5,10);
       figuras.Add(retangulo1);
       
       Circulo circulo1 = new Circulo("amarelo",2.5);
       figuras.Add(circulo1);

       foreach (Figura f in figuras)
        {
            Console.WriteLine($"A forma cor {f.ObterCor()} tem uma area de {f.ObterArea()}");
        }
       


       

    }
}