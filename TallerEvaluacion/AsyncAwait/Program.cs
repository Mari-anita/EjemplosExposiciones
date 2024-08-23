using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Inicio de la lectura de datos...");

            // Llamada al método asíncrono que simula la lectura de datos
            var datos = await LeerDatosAsync();

            // Imprimir los datos individualmente
            Console.WriteLine(datos[0]);
            Console.WriteLine(datos[1]);
            Console.WriteLine(datos[2]);
            Console.WriteLine(datos[3]);
            Console.WriteLine(datos[4]);

            Console.WriteLine("Fin de la lectura de datos.");

            Console.ReadLine();
        }

        public static async Task<string[]> LeerDatosAsync()
        {
            Console.WriteLine("Simulando la lectura de datos...");

            // Simula un retraso de 3 segundos como si estuvieras leyendo datos de una base de datos o archivo
            await Task.Delay(3000);

            // Simula los datos leídos mientras finaliza la espera de 3 segundos
            string[] datosLeidos = { "Dato 1", "Dato 2", "Dato 3", "Dato 4", "Dato 5" };

            Console.WriteLine("Lectura de datos completada.");
            return datosLeidos;
        }
    }
}
