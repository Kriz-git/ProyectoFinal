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
    public partial class FrmEmpleados : Form
    {

        CLempleados CLempleados = new CLempleados();

        public FrmEmpleados()
        {
            CDempleados cDempleados = new CDempleados();
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            lblFecha.Text = CLempleados.mtdfecha().ToString("dd/MM/yyyy");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mtdLimpiar()
        {
            txtCodigoEmpleado.Clear();
            txtNombre.Clear();
            cboxPuesto.Text = "";
            txtSalario.Clear();
            dtpFechaContratacion.Text = "";
            cboxEstado.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiar();
        }

        private void cboxPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalario.Text = CLempleados.MdtSalarioEmpleado(cboxPuesto.Text).ToString("c");
        }

        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoEmpleado.Text = DgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = DgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            cboxPuesto.Text = DgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtSalario.Text = DgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            dtpFechaContratacion.Text = DgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            cboxEstado.Text = DgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            //UsuarioSistema = DgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            //FechaSistema = DgvEmpleados.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtCodigoEmpleado.Text) || txtNombre.Text == "" || cboxPuesto.Text == "" || txtSalario.Text == "" || dtpFechaContratacion.Text == "" || cboxEstado.Text == ""))
                {
                    MessageBox.Show("Los campos no pueden estar en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int Contafila = DgvEmpleados.Rows.Add();
                    DgvEmpleados.Rows[Contafila].Cells[0].Value = txtCodigoEmpleado.Text;
                    DgvEmpleados.Rows[Contafila].Cells[1].Value = txtNombre.Text;
                    DgvEmpleados.Rows[Contafila].Cells[2].Value = cboxPuesto.Text;
                    DgvEmpleados.Rows[Contafila].Cells[3].Value = txtSalario.Text;
                    DgvEmpleados.Rows[Contafila].Cells[4].Value = dtpFechaContratacion.Text;
                    DgvEmpleados.Rows[Contafila].Cells[5].Value = cboxEstado.Text;

                    MessageBox.Show("Datos Agregados Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdLimpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtCodigoEmpleado.Text) || txtNombre.Text == "" || cboxPuesto.Text == "" || txtSalario.Text == "" || dtpFechaContratacion.Text == "" || cboxEstado.Text == ""))
                {
                    MessageBox.Show("Los campos no pueden estar en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int editar = DgvEmpleados.CurrentRow.Index;
                    DgvEmpleados.Rows[editar].Cells[0].Value = txtCodigoEmpleado.Text;
                    DgvEmpleados.Rows[editar].Cells[1].Value = txtNombre.Text;
                    DgvEmpleados.Rows[editar].Cells[2].Value = cboxPuesto.Text;
                    DgvEmpleados.Rows[editar].Cells[3].Value = txtSalario.Text;
                    DgvEmpleados.Rows[editar].Cells[4].Value = dtpFechaContratacion.Text;
                    DgvEmpleados.Rows[editar].Cells[5].Value = cboxEstado.Text;

                    MessageBox.Show("Datos Editado Correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtdLimpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int eliminarfila = DgvEmpleados.CurrentRow.Index;

            DgvEmpleados.Rows.RemoveAt(eliminarfila);
        }
    }
}
