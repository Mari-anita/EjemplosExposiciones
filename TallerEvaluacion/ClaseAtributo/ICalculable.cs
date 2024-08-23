using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAtributo
{
    public interface ICalculable
    {
        //el virtual va en la base derivada/heredada y el override en la clase base
        public void CalcularSalario();
    }
}
