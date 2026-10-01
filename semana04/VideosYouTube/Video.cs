using System.Collections.Generic;  // precisamos disso para usar List

public class Video
{
    // Atributos
    public string Titulo;
    public string Autor;
    public int DuracaoSegundos;
    public List<Comentario> Comentarios = new List<Comentario>();

    // Método que retorna quantos comentários tem
    public int NumeroDeComentarios()
    {
        return Comentarios.Count;
    }
}