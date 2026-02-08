using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioDashboard
{
    public partial class Login : Form
    {
        private CapaNegocio _capaNegocio;
        public Login()
        {
            InitializeComponent();
            _capaNegocio = new CapaNegocio();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            ValidarAcceso();
        }

        private void ValidarAcceso()
        {
            string user = txtUsuario.Text;
            string clave = txtClave.Text;

            Usuario users = _capaNegocio.AccesoSistema(user, clave);

            if (users != null)
            {
                Sesion.SesionActual = users;

                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                this.Close();

                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Usuario invalido, intelo de nuevo.");
            }
        }
    }
}
