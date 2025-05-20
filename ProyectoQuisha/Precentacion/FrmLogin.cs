using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoQuisha.Precentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
