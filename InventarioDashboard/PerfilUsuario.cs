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
    public partial class PerfilUsuario : UserControl
    {
        public PerfilUsuario()
        {
            InitializeComponent();
        }

        private void PerfilUsuario_Load(object sender, EventArgs e)
        {
            MostrarPerfil();
        }

        private void MostrarPerfil()
        {
            Usuario user = Sesion.SesionActual;
            txtUsuario.Text = user.Users;
            txtNombre.Text = user.NombreUsuario;
            txtEmail.Text = user.EmailUsuario;
            txtRol.Text = user.Rol;
        }
    }
}
