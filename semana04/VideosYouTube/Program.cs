using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // ===== VÍDEO 1 =====
        Video video1 = new Video();
        video1.Titulo = "Aprender C# do Zero";
        video1.Autor = "Canal Dev";
        video1.DuracaoSegundos = 600;

        Comentario c1 = new Comentario();
        c1.Nome = "Ana";
        c1.Texto = "Ótimo vídeo!";
        video1.Comentarios.Add(c1);

        Comentario c2 = new Comentario();
        c2.Nome = "Bruno";
        c2.Texto = "Me ajudou muito.";
        video1.Comentarios.Add(c2);

        Comentario c3 = new Comentario();
        c3.Nome = "Carla";
        c3.Texto = "Explicação clara!";
        video1.Comentarios.Add(c3);

        // ===== VÍDEO 2 =====
        Video video2 = new Video();
        video2.Titulo = "Programação Orientada a Objetos";
        video2.Autor = "Code Academy";
        video2.DuracaoSegundos = 900;

        Comentario c4 = new Comentario();
        c4.Nome = "Daniel";
        c4.Texto = "Muito bom!";
        video2.Comentarios.Add(c4);

        Comentario c5 = new Comentario();
        c5.Nome = "Eduarda";
        c5.Texto = "Aprendi bastante.";
        video2.Comentarios.Add(c5);

        Comentario c6 = new Comentario();
        c6.Nome = "Felipe";
        c6.Texto = "Recomendo!";
        video2.Comentarios.Add(c6);

        // ===== VÍDEO 3 =====
        Video video3 = new Video();
        video3.Titulo = "Dicas de VS Code";
        video3.Autor = "Tech Tips";
        video3.DuracaoSegundos = 450;

        Comentario c7 = new Comentario();
        c7.Nome = "Gabriela";
        c7.Texto = "Adorei as dicas!";
        video3.Comentarios.Add(c7);

        Comentario c8 = new Comentario();
        c8.Nome = "Henrique";
        c8.Texto = "Muito útil.";
        video3.Comentarios.Add(c8);

        Comentario c9 = new Comentario();
        c9.Nome = "Isabela";
        c9.Texto = "Já salvei aqui!";
        video3.Comentarios.Add(c9);

        // ===== COLOCAR TODOS OS VÍDEOS NUMA LISTA =====
        List<Video> listaDeVideos = new List<Video>();
        listaDeVideos.Add(video1);
        listaDeVideos.Add(video2);
        listaDeVideos.Add(video3);

        // ===== PERCORRER A LISTA E MOSTRAR TUDO =====
        foreach (Video v in listaDeVideos)
        {
            Console.WriteLine("Título: " + v.Titulo);
            Console.WriteLine("Autor: " + v.Autor);
            Console.WriteLine("Duração: " + v.DuracaoSegundos + " segundos");
            Console.WriteLine("Número de comentários: " + v.NumeroDeComentarios());
            Console.WriteLine("Comentários:");

            foreach (Comentario coment in v.Comentarios)
            {
                Console.WriteLine("  - " + coment.Nome + ": " + coment.Texto);
            }

            Console.WriteLine(); // linha em branco entre vídeos
        }
    }
}