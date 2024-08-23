using System;

namespace SRP
{
    // Clase que tiene una única responsabilidad: almacenar información de un libro.
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
    }

    // Clase que tiene una única responsabilidad: imprimir información del libro.
    public class LibroInfo
    {
        public void Print(Libro libro)
        {
            Console.WriteLine($"{libro.Titulo} de {libro.Autor}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Book.
            Libro libro = new Libro { Titulo = "Boulevard", Autor = "Flor M. Salvador" };

            // Crear una instancia de LibroInfo.
            LibroInfo info = new LibroInfo();

            // Imprimir la información del libro.
            info.Print(libro);
            Console.ReadLine();
        }
    }

}