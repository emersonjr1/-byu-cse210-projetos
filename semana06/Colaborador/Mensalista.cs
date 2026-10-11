public class Mensalista : Colaborador
{
    private float _salarioMensal = 0;

    public float ObterSalarioMensal()
    {
        return _salarioMensal;
    }


    public void DefinirSalarioMensal(float salario)
    {
        _salarioMensal = salario;
    }

    public override float Pagamento()
    {
        return _salarioMensal;
    }
}