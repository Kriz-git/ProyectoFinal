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

        public double MdtSalarioEmpleado(string cargo)
        {
            if (cargo == "Gerente")            return 35000;
            else if (cargo == "Recepcionista") return  7000;
            else if (cargo == "Botones")       return  5000;
            else if (cargo == "Conserje")      return  3000;
            else if (cargo == "Chef")         return  1000;
            else return 0;
        }

    }
}
