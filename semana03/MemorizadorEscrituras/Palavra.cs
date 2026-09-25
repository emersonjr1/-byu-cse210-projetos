using System;

class Palavra
{
    private string _texto;
    private bool _estaOculta;
    
    public Palavra(string texto)
    {
        _texto = texto;
        _estaOculta = false;
    }

    public void Ocultar()
    {
        _estaOculta = true;
    }

    public void Exibir()
    {
        _estaOculta = false;
    }

    public bool EstaOculta()
    {
        return _estaOculta;
    }

    public string ObterTexto()
    {

        if (_estaOculta)
        {
            return new string('_', _texto.Length);
        }
        else
        {
            return _texto;
        }
    }

}