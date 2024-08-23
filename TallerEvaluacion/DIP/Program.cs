using System;

namespace DIP
{
    // Interfaz para enviar mensajes
    public interface IMensaje
    {
        void Enviar(string mensaje);
    }

    // Implementación de la interfaz para enviar un mensaje por consola
    public class MensajeConsola : IMensaje
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"Mensaje enviado: {mensaje}");
        }
    }

    // Clase que depende de la abstracción (IMensaje) y no de la implementación
    public class Notificador
    {
        private IMensaje _mensaje; //Es un campo privado dentro de la clase Notificador
                                   //que guarda una referencia a un objeto que implementa
                                   //la interfaz IMensaje. Esta interfaz define lo que significa
                                   //"enviar un mensaje", pero no dice cómo hacerlo (por ejemplo, enviar por correo electrónico, por consola, etc.).

        public Notificador(IMensaje mensaje) //Es el constructor de la clase Notificador.
                                             //Se utiliza para crear una instancia de Notificador
                                             //y recibe como parámetro un objeto que implementa
                                             //la interfaz IMensaje. Este objeto se asigna
                                             //al campo _mensaje dentro de la clase.
        {
            _mensaje = mensaje;
        }

        public void EnviarNotificacion(string texto) //Es un método que permite enviar una notificación.
                                                     //Internamente, llama al método Enviar del
                                                     //objeto _mensaje, pasando el texto que se quiere enviar.
        {
            _mensaje.Enviar(texto);
        }
    }

    class Program
    {
        static void Main()
        {
            // Usamos la interfaz IMensaje y una implementación concreta (MensajeConsola)
            IMensaje mensaje = new MensajeConsola(); //Aquí se está creando un objeto de la clase MensajeConsola,
                                                     //que es una implementación concreta de la interfaz IMensaje.
                                                     //Esto significa que MensajeConsola define cómo se envía un mensaje (en este caso, por consola).

            Notificador notificador = new Notificador(mensaje);  //Luego, se crea un objeto de la clase Notificador
                                                                 //y se le pasa el objeto mensaje que acabamos de crear.
                                                                 //Esto significa que el Notificador usará MensajeConsola
                                                                 //para enviar mensajes.

            // Enviamos una notificación
            notificador.EnviarNotificacion("Hola Mundo!");

            // Pausa para ver el resultado en la consola
            Console.ReadLine();
        }
    }
}
