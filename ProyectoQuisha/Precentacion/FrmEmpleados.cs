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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoQuisha
{
    public partial class FrmEmpleados : Form
    {

        CLempleados CLempleados = new CLempleados();
        CDempleados CDempleados = new CDempleados();

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            lblFecha.Text = CLempleados.mtdfecha().ToString("dd/MM/yyyy");
            MtdConsultarEmpleados();
        }
        private void MtdConsultarEmpleados()
        {
            DataTable dt = CDempleados.MtdConsultarEmpleados();
            DgvEmpleados.DataSource = dt;

        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

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
            txtSalario.Text = CLempleados.MdtSalarioEmpleado(cboxPuesto.Text).ToString();
        }

        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = DgvEmpleados.SelectedRows[0];

            if (FilaSeleccionada.Index == DgvEmpleados.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoEmpleado.Text = DgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = DgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                cboxPuesto.Text = DgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtSalario.Text = DgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                dtpFechaContratacion.Text = DgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                cboxEstado.Text = DgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxPuesto.Text) || string.IsNullOrEmpty(txtSalario.Text)
            || string.IsNullOrEmpty(dtpFechaContratacion.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nombre = txtNombre.Text;
                string cargo = cboxPuesto.Text;
                double salario = int.Parse(txtSalario.Text);
                DateTime fechaContratacion = dtpFechaContratacion.Value;
                string estado = cboxEstado.Text;
                string usuarioSistema = "Crisitian";
                DateTime FechaSistema = CLempleados.mtdfecha();

                try
                {
                    CDempleados.MtdAgregarEmpleados(nombre, cargo, salario, fechaContratacion, estado, usuarioSistema, FechaSistema);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
                    mtdLimpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxPuesto.Text) || string.IsNullOrEmpty(txtSalario.Text)
                    || string.IsNullOrEmpty(dtpFechaContratacion.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Los campos no pueden estar en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigoEmpleado = int.Parse(txtCodigoEmpleado.Text);
                string nombre = txtNombre.Text;
                string cargo = cboxPuesto.Text;
                int salario = int.Parse(txtSalario.Text);
                DateTime fechaContratacion = dtpFechaContratacion.Value;
                string estado = cboxEstado.Text;
                string usuarioSistema = "Crisitian";
                DateTime FechaSistema = CLempleados.mtdfecha();

                try
                {
                    CDempleados.MtdActualizarEmpleados(codigoEmpleado, nombre, cargo, salario, fechaContratacion, estado, usuarioSistema, FechaSistema);
                    MessageBox.Show("Datos editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
                    mtdLimpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoEmpleado.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoProveedor = int.Parse(txtCodigoEmpleado.Text);

                try
                {
                    CDempleados.MtdEliminarEmpleados(CodigoProveedor);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
                    mtdLimpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
