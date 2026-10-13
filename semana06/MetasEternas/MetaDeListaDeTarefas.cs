using System.Numerics;
using System.Security.AccessControl;

public class MetaDeListaDeTarefas : Meta
{
    public int _concluidas;
    public int _total;
    public int _bonus;



    public MetaDeListaDeTarefas(string nome, string descricao, int pontos, int total, int bonus) : base (nome, descricao, pontos)
    {
        
        _concluidas = total;
        _bonus = bonus;

    }

    public override void RegistrarEvento()
    {
        if( _concluidas < _total)
        {
            _concluidas = _concluidas + 1;
        }
    }


    public override bool EstaConcluida()
    {
        if (_concluidas >= _total)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public override string ObterDetalhesEmTexto()
    {
        string status;

        // Verifica se está concluída usando if / else
        if (EstaConcluida() == true)
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }

        // Retorna o formato exibindo o progresso atual (ex: Concluído: 2/5)
        return $"{status} {_nome} ({_descricao}) -- Concluído: {_concluidas}/{_total}";
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaDeListaDeTarefas:{_nome},{_descricao},{_pontos},{_bonus},{_total},{_concluidas}";
    }




}