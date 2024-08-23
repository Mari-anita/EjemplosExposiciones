using System;

namespace LSP
{
    public class Animal //tiene el método Sonido. Este método está marcado como virtual,
                        //lo que significa que puede ser sobrescrito (modificado)
                        //por cualquier clase que herede de Animal.
    {
        public virtual void Sonido()
        {
            Console.WriteLine("Sonido que hace un animal");
        }
    }

    public class Perro : Animal //Esta clase hereda de Animal.
                                //Usa la palabra clave override para sobrescribir el método Sonido
                                //de la clase base.
    {
        public override void Sonido() //Sonido se llama una instancia de Perro,
                                      //la cual imprimirá "Guau!" en lugar del mensaje de la clase base.
        {
            Console.WriteLine("Guau!");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal miPerro = new Perro(); //se crea una instancia de Perro,
                                          //pero se almacena en una variable de tipo Animal.
                                          //Esto es posible porque Perro hereda de Animal por eso es un tipo de animal

            miPerro.Sonido(); //Se llama al método Sonido en la instancia,
                              //lo que ejecuta la versión sobrescrita del método en Perro
                              //y muestra "Guau!" en la consola.

            Console.ReadLine();
        }
    }

}