using Microsoft.VisualBasic;
using ProyectoQuisha.Datos;
using ProyectoQuisha.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoQuisha
{
    public partial class FrmUsuarios : Form
    {
        CDusuarios CDusuarios = new CDusuarios();
        CLusuarios CLusuarios = new CLusuarios();


        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MtdLimpiar()
        {
            CboxCodigoEmpleado.Text = "";
            txtCodigoUsuario.Clear();
            txtNombreUsuario.Clear();
            txtPASS.Clear();
            cboxEstado.Text = "";
            CboxRol.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiar();
        }

        private void MtdMostrarCodigoEmpleado()
        {
            var ListaCodigoEmpleado = CDusuarios.MtdCodigoEmpleado();
            CboxCodigoEmpleado.Items.Clear();

            foreach (var reservaciones in ListaCodigoEmpleado)
            {
                CboxCodigoEmpleado.Items.Add(reservaciones);
            }

            CboxCodigoEmpleado.DisplayMember = "Text";
            CboxCodigoEmpleado.ValueMember = "Value";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtPASS.Text)|| string.IsNullOrEmpty(CboxRol.Text)
                || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string NombreUsuario = txtNombreUsuario.Text;
                string Contrasenia = txtPASS.Text;
                string Rol = CboxRol.Text;
                string Estado = cboxEstado.Text;
                string usuarioSistema = "Crisitian";
                DateTime FechaSistema = CLusuarios.mtdfecha();
                var selectedCodigoEmpleados = (dynamic)CboxCodigoEmpleado.SelectedItem;
                int CodigoEmpleados = (int)selectedCodigoEmpleados.Value;

                try
                {

                    CDusuarios.MtdAgregarUsuarios(CodigoEmpleados, NombreUsuario, Contrasenia, Rol, Estado, usuarioSistema, FechaSistema);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuarios();
                    MtdLimpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = DgvUsuarios.SelectedRows[0];

            if (FilaSeleccionada.Index == DgvUsuarios.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoUsuario.Text = DgvUsuarios.CurrentRow.Cells[0].Value.ToString();

                txtNombreUsuario.Text = DgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtPASS.Text = DgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                CboxRol.Text = DgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                cboxEstado.Text = DgvUsuarios.CurrentRow.Cells[5].Value.ToString();

                int CodigoEmpleados = (int)DgvUsuarios.SelectedCells[1].Value;
                foreach (var CodigoEmpleado in CboxCodigoEmpleado.Items)
                {
                    if (((dynamic)CodigoEmpleado).Value == CodigoEmpleados)
                    {
                        CboxCodigoEmpleado.SelectedItem = CodigoEmpleado;
                        
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtPASS.Text) || string.IsNullOrEmpty(CboxRol.Text)
                || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                
                string NombreUsuario = txtNombreUsuario.Text;
                string Contrasenia = txtPASS.Text;
                string Rol = CboxRol.Text;
                string Estado = cboxEstado.Text;
                string usuarioSistema = "Crisitian";
                int CodigoEmpleados = (int)((dynamic)CboxCodigoEmpleado.SelectedItem).Value;
                DateTime FechaSistema = CLusuarios.mtdfecha();
                var selectedCodigoEmpleados = (dynamic)CboxCodigoEmpleado.SelectedItem;
                

                try
                {
                    CDusuarios.MtdEditarUsuarios(CodigoEmpleados, NombreUsuario, Contrasenia, Rol, Estado, usuarioSistema, FechaSistema);
                    MessageBox.Show("Datos Editados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuarios();
                    MtdLimpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoUsuario.Text))
            {
                MessageBox.Show("Favor seleccionar medicamento a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoUsuario = (int.Parse(txtCodigoUsuario.Text));

                    CDusuarios.MtdEliminarUsuarios(CodigoUsuario);
                    MessageBox.Show("Medicamento eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuarios();
                    MtdLimpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MtdConsultarUsuarios();
            MtdMostrarCodigoEmpleado();
        }

        private void MtdConsultarUsuarios()
        {
            DataTable dt = CDusuarios.MtdConsultarUsuarios();
            DgvUsuarios.DataSource = dt;

        }

        private void CboxCodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCodigoEmpleados = (dynamic)CboxCodigoEmpleado.SelectedItem;
            int CodigoEmpleados = (int)selectedCodigoEmpleados.Value;
            string nombre = (string)selectedCodigoEmpleados.Text;
            CboxCodigoEmpleado.Text = CLusuarios.MtdCodigoEmpleado(CodigoEmpleados).ToString();
            txtNombreUsuario.Text = CLusuarios.MtdNombre(nombre).ToString();

        }
    }
}
