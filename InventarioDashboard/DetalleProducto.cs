using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioDashboard
{
    public partial class DetalleProducto : Form
    {
        private CapaNegocio _capaNegocio;
        private Producto _producto;
        private ControlProductos _controlProducto;
        public DetalleProducto(ControlProductos controlProducto)
        {
            InitializeComponent();
            _capaNegocio = new CapaNegocio();
            _controlProducto = controlProducto;
            _producto = null;
        }

        private void btnCerrarDetalleProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            Guna2TextBox[] campos = new Guna2TextBox[] {txtCodigoProducto, txtNombreProducto, txtTallaProducto,
            txtColorProducto, txtPrecioProducto};
            if(ValidarCampos(campos, cmbCategoria, nudStockProducto, dtpFechaProducto))
            {
                GuardarProducto();
                this.Close();
                _controlProducto.CargarGrillaProductos();
            }
        }

        private void GuardarProducto()
        {
            Producto producto = new Producto();
            producto.CodigoProducto = txtCodigoProducto.Text;
            producto.NombreProducto = txtNombreProducto.Text;
            producto.IdCategoria = (int)cmbCategoria.SelectedValue;
            producto.TallaProducto = txtTallaProducto.Text;
            producto.ColorProducto = txtColorProducto.Text;
            producto.PrecioUnitario = decimal.Parse(txtPrecioProducto.Text);
            producto.FechaIngreso = dtpFechaProducto.Value;
            producto.StockProducto = (int)nudStockProducto.Value;

            producto.IdProducto = _producto != null ? _producto.IdProducto : 0;

            _capaNegocio.GuardarProducto(producto);
        }

        public void CargarDatosDetalleProducto(Producto producto)
        {
            _producto = producto;
            if(producto != null)
            {
                LimpiarCampos();
                txtCodigoProducto.Text = producto.CodigoProducto;
                txtNombreProducto.Text = producto.NombreProducto;
                cmbCategoria.SelectedValue = producto.IdCategoria;
                txtTallaProducto.Text = producto.TallaProducto;
                txtColorProducto.Text = producto.ColorProducto;
                txtPrecioProducto.Text = producto.PrecioUnitario.ToString();
                dtpFechaProducto.Value = producto.FechaIngreso;
                nudStockProducto.Value = producto.StockProducto;
            }
        }
        private bool ValidarCampos(Guna2TextBox[] campos, Guna2ComboBox combo, Guna2NumericUpDown numerico,
            Guna2DateTimePicker fecha)
        {
            bool validar = true;
            errorProductos.Clear();

            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo.Text))
                {
                    errorProductos.SetError(campo, "Complete el campo.");
                    validar = false;
                }
            }

            if(int.Parse(combo.SelectedValue.ToString()) == -1)
            {
                errorProductos.SetError(combo, "Seleccione una opcion correcta.");
                validar = false;
            }

            if(numerico.Value == 0)
            {
                errorProductos.SetError(numerico, "El stock tiene que ser mayor de 0.");
                validar = false;
            }

            if(fecha.Value.Date < DateTime.Now.Date)
            {
                errorProductos.SetError(fecha, "Digite una fecha valida.");
                validar = false;
            }

            return validar;
        }
        private void DetalleProducto_Load_1(object sender, EventArgs e)
        {
            CargarComboBoxCategoria();

            if(_producto != null)
            {
                CargarDatosDetalleProducto(_producto);
            }
            else
            {
                dtpFechaProducto.Value = DateTime.Now;
            }
        }
        private void CargarComboBoxCategoria()
        {
            List<Categoria> categorias = _capaNegocio.ListarCategorias();

            categorias.Insert(0, new Categoria
            {
                IdCategoria = -1,
                NombreCategoria = "Selecciona una categoria."
            });

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void LimpiarCampos()
        {
            txtCodigoProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            cmbCategoria.SelectedValue = -1;
            txtTallaProducto.Text = string.Empty;
            txtColorProducto.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;
            dtpFechaProducto.Value = DateTime.Now;
            nudStockProducto.Value = 0;
        }
    }
}
