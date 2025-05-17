using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoQuisha.Logica
{
    internal class CLempleados
    {

        public DateTime mtdfecha()
        {           
            return DateTime.Now;
        }

        public double MdtSalarioEmpleado(string Puesto)
        {
            if (Puesto == "Gerente")            return 35000;
            else if (Puesto == "Recepcionista") return  7000;
            else if (Puesto == "Botones")       return  5000;
            else if (Puesto == "Conserje")      return  3000;
            else if (Puesto == "Chef")         return  1000;
            else return 0;
        }

    }
}
