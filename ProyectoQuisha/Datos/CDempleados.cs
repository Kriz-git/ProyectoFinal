using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoQuisha.Datos
{
    public class CDempleados
    {
        CDConexion cd_conexion = new CDConexion();

        public DataTable MtdConsultarEmpleados()
        {
            string QueryConsultarEmplados = "select * from tbl_Empleado";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarEmplados, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

    }
}
