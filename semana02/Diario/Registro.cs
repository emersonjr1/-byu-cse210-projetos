using System;

class Registro
{
    public string _data;
    public string _textoPergunta;
    public string _textoResposta;

    public void Exibir()
    {
        Console.WriteLine($"{_data} - { _textoPergunta} - {_textoResposta}");
    }
}