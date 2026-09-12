public class Emprego
{
    public string _empresa;
    public string _cargo;
    public string _anoInicio;
    public string _anoFim;

    public void Exibir()
    {
        Console.WriteLine($"{_cargo} ({_empresa}) {_anoInicio}-{_anoFim};");
    }
}