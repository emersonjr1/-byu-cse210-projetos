using System;

public class MetaEterna : Meta
{

    public MetaEterna(string nome, string descricao, int pontos): base(nome, descricao, pontos)
    {


        
    }

    public override void RegistrarEvento()
    {
        
    }



    public override bool EstaConcluida()
    {
        return true;
    }

    public override string ObterDetalhesEmTexto()
    {
       string status;

        // Como ela nunca é concluída, o status pode usar um símbolo de infinito [∞]
        // ou você pode manter o [ ] se preferir o padrão das outras.
        if (EstaConcluida() == true)
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]"; // Ou "[∞]" dependendo de como prefere exibir
        }

        return $"{status} {_nome} ({_descricao})";
    }


    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaEterna:{_nome},{_descricao},{_pontos}";
    }   
    
}