public class Horista : Colaborador
{
    
    private float _valorHora = 0;
    private float _horasTrabalhadas = 0;
    
    public float ObterValorHora(float valor)
    {
        return _valorHora;
    }


    public float ObterHorasTrabalhadas()
    { 
        return _horasTrabalhadas;
    }

    public void DefinirHorasTrabalhadas(float horasTrabalhadas)
    {
        _horasTrabalhadas = horasTrabalhadas;

    }

    public void DefinirValorHora(float valorHora)
    {
        _valorHora = valorHora;
    }

    public override float Pagamento()
    {
        return _horasTrabalhadas * _valorHora;
    }
}
