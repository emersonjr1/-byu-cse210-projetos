using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

public class Quadrado : Figura
{
    private double _lado;

    public Quadrado(string cor, double lado) : base(cor)
    {
        _lado = lado;
    }
    public override double ObterArea()
    {
        double area = _lado * _lado;
        return area;
    }
    

}