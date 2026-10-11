
public class Circulo :  Figura
{
    
    private double _raio;

    public Circulo(string cor, double raio) : base(cor)
    {
        _raio = raio;
    }


    public override double ObterArea()
    {
 
        double area = Math.PI *  Math.Pow(_raio, 2);
        return area;
    }

}