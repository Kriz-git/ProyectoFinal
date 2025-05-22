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

            string QueryConsultarCodigoEmpleado = "Select CodigoEmpleados from tbl_Usuario where CodigoEmpleados=@CodigoEmpleados";
            SqlCommand CommandCodigoEmpleado = new SqlCommand(QueryConsultarCodigoEmpleado, cd_conexion.MtdAbrirConexion());
            CommandCodigoEmpleado.Parameters.AddWithValue("@CodigoEmpleados", CodigoEmpleados);
            SqlDataReader reader = CommandCodigoEmpleado.ExecuteReader();

            if (reader.Read())
            {
                CodigoEmpleados = int.Parse(reader["CodigoEmpleados"].ToString());
            }
            else
            {
                CodigoEmpleados = 0;
            }

            cd_conexion.MtdCerrarConexion();
            return CodigoEmpleados;
        }
    }
}
