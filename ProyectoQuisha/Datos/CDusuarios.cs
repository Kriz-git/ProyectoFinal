using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoQuisha.Datos
{
    internal class CDusuarios
    {
        CDConexion cd_conexion = new CDConexion();

        public DataTable MtdConsultarEmpleados()
        {
            string QueryConsultarUsuarios = "select * from tbl_Usuarios";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarUsuarios, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarUsuarios(string nombreUsuario, string PASS, string Rol, string Estado, string Puesto, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregar = "Insert into tbl_Usuarios (nombreUsuario, PASS, Rol, Estado, Puesto, UsuarioSistema, FechaSistema) " +
                                                "values (@nombreUsuario, @PASS, @Rol, @Estado, @Puesto, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@PASS", PASS);
            cmd.Parameters.AddWithValue("@Rol", Rol);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@Puesto", Puesto);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdModificarUsuarios(string nombreUsuario, string PASS, string Rol, string Estado, string Puesto, string UsuarioSistema, DateTime FechaSistema)
        {
            string Querymodificar = "Update tbl_Usuarios set (nombreUsuario=@nombreUsuario, PASS=@PASS, Rol=@ROl, Estado=@Estado, Puesto=@Puesto, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(Querymodificar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@PASS", PASS);
            cmd.Parameters.AddWithValue("@Rol", Rol);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@Puesto", Puesto);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

    }
}
