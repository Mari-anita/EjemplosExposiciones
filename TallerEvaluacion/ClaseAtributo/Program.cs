using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAtributo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Solicitar y leer información del usuario
            Console.Write("Ingrese su nombre: ");
            string Nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            string Edad = Console.ReadLine();

            Console.Write("Ingrese su direccion: ");
            string Direccion = Console.ReadLine();

            Console.Write("Ingrese su telefono: ");
            string Telefono = Console.ReadLine();

            // Crear una instancia de Empleado
            var empleado = new Empleado();

            // Leer y convertir los días trabajados
            Console.Write("Ingrese los días trabajados: ");
            string diasTrabajadosInput = Console.ReadLine();
            empleado.DiasTrabajados = int.Parse(diasTrabajadosInput); //se usa esto para convertirlo a int
                                                                      //ya que en consola todo lo toma como string

            // Leer y convertir el salario base
            Console.Write("Ingrese su salario base: ");
            string salarioBaseInput = Console.ReadLine();
            empleado.SalarioBase = decimal.Parse(salarioBaseInput); //se usa esto para convertirlo a int
                                                                    //ya que en consola todo lo toma como string

            // Simular una espera de 3 segundos
            Console.WriteLine("Simulando la espera de 3 segundos...");
            await Task.Delay(3000); // Espera de 3 segundos

            // Calcular el salario
            empleado.CalcularSalario(); //invoca el método CalcularSalario en la instancia de Empleado (empleado)
        }
    }
}
