using System;

public class MetaSimples : Meta
{
    private bool _estaConcluida;

    public MetaSimples(string nome, string descricao, int pontos) : base(nome, descricao, pontos)
    {
        _estaConcluida = false;
    }

    public override void RegistrarEvento()
    {
        _estaConcluida = true;
    }

    public override bool EstaConcluida()
    {
        return _estaConcluida;
    }

 
    public override string ObterDetalhesEmTexto()
    {


        // string status = _estaConcluida ? "[X]" : "[ ]";
        string status;

        if (_estaConcluida == true)
             status = "[X]";

        else
        {
            status = "[ ]";
        }

        return $"{status} {_nome} ({_descricao})";
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"{_estaConcluida} MetaSimples:{_nome},{_descricao},{_pontos}";
    }
}