using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoQuisha.Precentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUSUARIO_Enter(object sender, EventArgs e)
        {
            if (txtUSUARIO.Text == "Usuario")
            {
                txtUSUARIO.Text = "";
                txtUSUARIO.ForeColor = Color.LightGray;
            }
        }

        private void txtUSUARIO_Leave(object sender, EventArgs e)
        {
            if (txtUSUARIO.Text == "")
            {
                txtUSUARIO.Text = "Usuario";
                txtUSUARIO.ForeColor = Color.Silver;
            }
        }

        private void txtPASS_Enter(object sender, EventArgs e)
        {
            if (txtPASS.Text == "Contraseña")
            {
                txtPASS.Text = "";
                txtPASS.ForeColor = Color.LightGray;
                txtPASS.UseSystemPasswordChar = true;
            }
        }

        private void txtPASS_Leave(object sender, EventArgs e)
        {
            if (txtPASS.Text == "")
            {
                txtPASS.Text = "Contraseña";
                txtPASS.ForeColor = Color.Silver;
                txtPASS.UseSystemPasswordChar = false;
            }
        }
    }
}
