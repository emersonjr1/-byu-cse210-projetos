using System;
using System.Collections.Generic;
 

public class Curriculo
{
    public string _name;
    public List<Emprego> _empregos = new List<Emprego>();

    public void MostrarEmpregos()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Curriculo: ");
        
        foreach (Emprego meusEmpregos in _empregos)
        {
            meusEmpregos.Exibir();
        }
    }
    
}