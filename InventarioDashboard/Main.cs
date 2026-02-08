using Guna.UI2.WinForms;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void AbrirModulo(UserControl modulo)
        {
            panelContenido.Controls.Clear();
            modulo.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(modulo);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirModulo(new ControlProductos());
            MarcarBottonActivo(btnProducto);
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            AbrirModulo(new ControlMovimientos());
            MarcarBottonActivo(btnMovimiento);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirModulo(new ControlCategorias());
            MarcarBottonActivo(btnCategoria);
        }

        private void MarcarBottonActivo(Guna2Button buttonActivo)
        {
            btnCategoria.FillColor = Color.Transparent;
            btnProducto.FillColor = Color.Transparent;
            btnMovimiento.FillColor = Color.Transparent;
            btnMenuUser.FillColor = Color.Transparent;

            buttonActivo.FillColor = Color.Silver;
        }

        private void btnMenuUser_Click(object sender, EventArgs e)
        {
            AbrirMenuClickIzquierdo();
        } 

        private void AbrirMenuClickIzquierdo()
        {
            cmsMenuUser.Show(btnMenuUser, new Point(0, btnMenuUser.Height));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AbrirModulo(new ControlProductos());
            MarcarBottonActivo(btnProducto);
        }

        private void cmsMenuUser_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Salir")
            {
                this.Close();
            }
            else if (e.ClickedItem.ToString() == "Ver perfil")
            {
                MarcarBottonActivo(btnMenuUser);
                AbrirModulo(new PerfilUsuario());
            }
            else if (e.ClickedItem.ToString() == "Cerrar Sesión")
            {
                Login login = new Login();

                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
