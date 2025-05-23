using ProyectoQuisha.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoQuisha.Logica
{
    internal class CLusuarios
    {
        CDConexion cd_conexion = new CDConexion();



        public DateTime mtdfecha()
        {
            return DateTime.Now;
        }

        public double MtdCodigoEmpleado(int CodigoEmpleados)
        {

            string QueryConsultarCodigoEmpleado = "Select CodigoEmpleado, nombre from tbl_Empleado where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand CommandCodigoEmpleado = new SqlCommand(QueryConsultarCodigoEmpleado, cd_conexion.MtdAbrirConexion());
            CommandCodigoEmpleado.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleados);
            SqlDataReader reader = CommandCodigoEmpleado.ExecuteReader();

            if (reader.Read())
            {
                CodigoEmpleados = int.Parse(reader["CodigoEmpleado"].ToString());
            }
            else
            {
                CodigoEmpleados = 0;
            }

            cd_conexion.MtdCerrarConexion();
            return CodigoEmpleados;
        }

        public string MtdNombre(string nombre)
        {

            string QueryConsultarnombre = "Select nombre from tbl_Empleado";
            SqlCommand Commandnombre = new SqlCommand(QueryConsultarnombre, cd_conexion.MtdAbrirConexion());
            Commandnombre.Parameters.AddWithValue("@nombre", nombre);
            SqlDataReader reader = Commandnombre.ExecuteReader();

            if (reader.Read())
            {
                nombre = (reader["nombre"].ToString());
            }
            else
            {
                nombre = "";
            }

            cd_conexion.MtdCerrarConexion();
            return nombre;
        }

    }
}
