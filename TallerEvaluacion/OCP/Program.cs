using System;

namespace OCP
{
    using System;

    public class Saludar //Es una clase base que tiene un método Saludo.
                         //Este método está marcado como virtual, lo que significa que puede
                         //ser sobrescrito (modificado) por cualquier clase que herede de Saludar.
    {

        public virtual void Saludo()
        {
            Console.WriteLine("Holaa!");
        }
    }

    public class SaludoAmistoso : Saludar //Esta clase hereda de Saludar.
                                          //Usa la palabra clave override para sobrescribir
                                          //el método Saludo de la clase base.
    {
        public override void Saludo() //Cuando Saludo se llama en una instancia de SaludoAmistoso(34),
                                      //imprimirá "¡Hola! ¡Qué bueno verte!"
                                      //en lugar del mensaje de la clase base.
        {
            Console.WriteLine("¡Hola! ¡Qué bueno verte!");
        }
    }

    class Program
    {
        static void Main()
        {
            Saludar saludar = new SaludoAmistoso(); //Aquí se crea una instancia de SaludoAmistoso,
            saludar.Saludo();                      //pero se almacena en una variable de tipo Saludar.
            Console.ReadLine();                   //Esto es posible porque SaludoAmistoso hereda de Saludar y, por lo tanto,
                                                  //es un tipo de Saludar.
                                                  //Luego, llama al método Saludo en la instancia,
                                                  //lo que ejecuta la versión sobrescrita del método en SaludoAmistoso
                                                  //y muestra "¡Hola! ¡Qué bueno verte!" en la consola.
        }
    }

}