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
            cboxPuesto.Text = "";
            CboxRol.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(CboxCodigoEmpleado.Text) || string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtPASS.Text)|| string.IsNullOrEmpty(CboxRol.Text)
                || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(cboxPuesto.Text))
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                string NombreUsuario = txtNombreUsuario.Text;
                string Contrasenia = txtPASS.Text;
                string Rol = CboxRol.Text;
                string Estado = cboxEstado.Text;
                string cargo = cboxPuesto.Text;
                string Puesto = cboxPuesto.Text;
                string usuarioSistema = "Crisitian";
                DateTime FechaSistema = CLusuarios.mtdfecha();

                try
                {
                    CDusuarios.MtdAgregarUsuarios(NombreUsuario, Contrasenia, Rol, Estado, Puesto, usuarioSistema, FechaSistema);
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
                CboxCodigoEmpleado.Text = DgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtNombreUsuario.Text = DgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtPASS.Text = DgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                CboxRol.Text = DgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                cboxEstado.Text = DgvUsuarios.CurrentRow.Cells[5].Value.ToString();
                cboxPuesto.Text = DgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(CboxCodigoEmpleado.Text) || (string.IsNullOrEmpty(txtCodigoUsuario.Text) || txtNombreUsuario.Text == "" || txtPASS.Text == "" ||
                    CboxRol.Text == "" || cboxEstado.Text == "" || cboxPuesto.Text == "")))
                {
                    MessageBox.Show("Los campos no pueden estar en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int Contafila = DgvUsuarios.CurrentRow.Index;
                    DgvUsuarios.Rows[Contafila].Cells[0].Value = txtCodigoUsuario.Text;
                    DgvUsuarios.Rows[Contafila].Cells[1].Value = CboxCodigoEmpleado.Text;
                    DgvUsuarios.Rows[Contafila].Cells[2].Value = txtNombreUsuario.Text;
                    DgvUsuarios.Rows[Contafila].Cells[3].Value = txtPASS.Text;
                    DgvUsuarios.Rows[Contafila].Cells[4].Value = CboxRol.Text;
                    DgvUsuarios.Rows[Contafila].Cells[5].Value = cboxEstado.Text;
                    DgvUsuarios.Rows[Contafila].Cells[6].Value = cboxPuesto.Text;

                    MessageBox.Show("Datos Editado Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdLimpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int eliminarfila = DgvUsuarios.CurrentRow.Index;

            DgvUsuarios.Rows.RemoveAt(eliminarfila);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MtdConsultarUsuarios();
        }

        private void MtdConsultarUsuarios()
        {
            DataTable dt = CDusuarios.MtdConsultarUsuarios();
            DgvUsuarios.DataSource = dt;

        }
    }
}
