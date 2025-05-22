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

        public DataTable MtdConsultarUsuarios()
        {
            string QueryConsultarUsuarios = "select * from tbl_Usuario";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarUsuarios, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarUsuarios(string NombreUsuario, string Contrasenia, string Rol, string Estado, string Puesto, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregar = "Insert into tbl_Usuario (NombreUsuario, Contrasenia, Rol, Estado, Puesto, UsuarioSistema, FechaSistema) " +
                                                "values (@NombreUsuario, @Contrasenia, @Rol, @Estado, @Puesto, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            cmd.Parameters.AddWithValue("@Contrasenia", Contrasenia);
            cmd.Parameters.AddWithValue("@Rol", Rol);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@Puesto", Puesto);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEditarUsuarios(string NombreUsuario, string Contrasenia, string Rol, string Estado, string Puesto, string UsuarioSistema, DateTime FechaSistema)
        {
            string Querymodificar = "Update tbl_Usuario set (NombreUsuario=@NombreUsuario, Contrasenia=@Contrasenia, Rol=@ROl, Estado=@Estado, Puesto=@Puesto, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(Querymodificar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            cmd.Parameters.AddWithValue("@Contrasenia", Contrasenia);
            cmd.Parameters.AddWithValue("@Rol", Rol);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@Puesto", Puesto);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarUsuarios(int codigoUsuario)
        {
            string QueryEliminar = "Delete from tbl_Usuario where codigoUsuario=@codigoUsuario";
            SqlCommand cmd = new SqlCommand(QueryEliminar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }


    }
}
