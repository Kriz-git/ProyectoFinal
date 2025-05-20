using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        public void MtdAgregarEmpleados(string nombre, string cargo, string salario, DateTime fechaContratacion, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregar = "Insert into tbl_Empleado (nombre, cargo, Salario, FechaContratacion, estado, usuarioSistema, FechaSistema) " +
                                                "values (@nombre, @cargo, @Salario, @FechaContratacion, @estado, @usuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@Salario", salario);
            cmd.Parameters.AddWithValue("@FechaContratacion", fechaContratacion);
            cmd.Parameters.AddWithValue("@estado", Estado);
            cmd.Parameters.AddWithValue("@usuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdModificarEmpleados(int CodigoEmpleado, string nombre, string cargo, string salario, DateTime fechaContratacion, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryModificar = "Update tbl_Empleado set nombre=@nombre, cargo=@cargo, Salario=@Salario, FechaContratacion=@FechaContratacion, estado=@estado, usuarioSistema=@usuarioSistema, FechaSistema=@FechaSistema where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryModificar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@Salario", salario);
            cmd.Parameters.AddWithValue("@FechaContratacion", fechaContratacion);
            cmd.Parameters.AddWithValue("@estado", Estado);
            cmd.Parameters.AddWithValue("@usuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarEmpleados(int CodigoEmpleado)
        {
            string QueryEliminar = "Delete from tbl_Empleado where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryEliminar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
