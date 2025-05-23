using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoQuisha.Logica;

namespace ProyectoQuisha.Datos
{
    internal class CDusuarios
    {
        CDConexion cd_conexion = new CDConexion();



        public List<dynamic> Mtdnombe()
        {
            List<dynamic> nombre = new List<dynamic>();
            string Querynombe = "Select nombre from tbl_Empleado";
            SqlCommand cmd = new SqlCommand(Querynombe, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                nombre.Add(new
                {
                    Value = reader["nombre"],
                    Text = $"{reader["nombre"]}"

                });
            }
            cd_conexion.MtdCerrarConexion();
            return nombre;
        }

        public List<dynamic> MtdCodigoEmpleado()
        {
            List<dynamic> CodigoEmpleado = new List<dynamic>();
            string QueryCodigoEmpleado = "Select CodigoEmpleado from tbl_Empleado";
            SqlCommand cmd = new SqlCommand(QueryCodigoEmpleado, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CodigoEmpleado.Add(new
                {
                    Value = reader["CodigoEmpleado"],
                    Text = $"{reader["CodigoEmpleado"]}"
             
                });
            }
            cd_conexion.MtdCerrarConexion();
            return CodigoEmpleado;
        }

        public DataTable MtdConsultarUsuarios()
        {
            string QueryConsultarUsuarios = "select * from tbl_Usuario";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarUsuarios, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarUsuarios(int CodigoEmpleado, string NombreUsuario, string Contrasenia, string Rol, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregar = "Insert into tbl_Usuario (CodigoEmpleado, NombreUsuario, Contrasenia, Rol, Estado, UsuarioSistema, FechaSistema) " +
                                                "values (@CodigoEmpleado, @NombreUsuario, @Contrasenia, @Rol, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            cmd.Parameters.AddWithValue("@Contrasenia", Contrasenia);
            cmd.Parameters.AddWithValue("@Rol", Rol);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEditarUsuarios(int CodigoEmpleado, string NombreUsuario, string Contrasenia, string Rol, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string Querymodificar = "Update tbl_Usuario set CodigoEmpleado=@CodigoEmpleado, NombreUsuario=@NombreUsuario," +
                " Contrasenia=@Contrasenia, Rol=@Rol, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(Querymodificar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            cmd.Parameters.AddWithValue("@Contrasenia", Contrasenia);
            cmd.Parameters.AddWithValue("@Rol", Rol);
            cmd.Parameters.AddWithValue("@Estado", Estado);
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
