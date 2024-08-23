using System;

namespace ISP
{
    public interface Trabajador //Esta interfaz define un método Trabajar,
                                //que debe ser implementado por cualquier clase que la implemente.
    {
        void Trabajar();
    }

    public interface IComer //Esta interfaz define un método Comer,
                            //que debe ser implementado por cualquier clase que la implemente.
    {
        void Comer();
    }

    public class Persona : Trabajador, IComer //La clase Persona implementa ambas interfaces: Trabajador e IComer
                                              //al igual que los metodos que tienen estas interfaces (trabajar,comer)
    {
        public void Trabajar()
        {
            Console.WriteLine("Trabajando");
        }

        public void Comer()
        {
            Console.WriteLine("Comiendo");
        }
    }

    class Program
    {
        static void Main()
        {
            Persona persona = new Persona(); //Crea una instancia de Persona,
                                             //llama a los métodos Trabajar y Comer,
                                             //y luego muestra el resultado en la consola.
            persona.Trabajar();
            persona.Comer();

            Console.ReadLine();
        }
    }

}