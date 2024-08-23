using ClaseAtributo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAtributo
{
    public class Empleado : Persona, ICalculable
    {
        public int DiasTrabajados { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal TotalPagar { get; set; }

        public Empleado()
        {
            
        }
            public void CalcularSalario()
        {
            TotalPagar = (SalarioBase / 30) * DiasTrabajados;
            // Mostrar el total a pagar dentro del método CalcularSalario
            Console.WriteLine($"El total a pagar es: {TotalPagar:C}"); //:C se usa para que el valor numérico se convierta
                                                                       //en una cadena que representa una cantidad monetaria,
                                                                       //incluyendo el símbolo de la moneda, como $

        }
    }
}
