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
    public partial class DetalleMovimiento : Form
    {
        private CapaNegocio _capaNegocio;
        private Movimiento _movimiento;
        private ControlMovimientos _controlMovimientos;
        public DetalleMovimiento(ControlMovimientos controlMovimientos)
        {
            InitializeComponent();
            _capaNegocio = new CapaNegocio();
            _movimiento = null;
            _controlMovimientos = controlMovimientos;
        }

        private void btnCerrarDetalleMovimiento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarMovimiento_Click(object sender, EventArgs e)
        {
            if(ValidarCampos(cmbProducto, txtObservacion, nudCantidadMovimiento, dtpFechaMovimiento))
            {
                GuardarMovimiento();
                this.Close();
                _controlMovimientos.CargarGrillaMovimiento();
            }
        }

        private void GuardarMovimiento()
        {
            Movimiento movimiento = new Movimiento();
            movimiento.IdProducto = (int)cmbProducto.SelectedValue;
            movimiento.TipoMovimiento = cmbTipoMovimiento.SelectedItem.ToString();
            movimiento.CantidadMovimiento = (int)nudCantidadMovimiento.Value;
            movimiento.FechaMovimiento = dtpFechaMovimiento.Value;
            movimiento.Observacion = txtObservacion.Text;

            movimiento.IdMovimiento = _movimiento != null ? _movimiento.IdMovimiento : 0;

            _capaNegocio.GuardarMovimiento(movimiento);
        }

        public void CargarDetalleMovimiento(Movimiento movimiento)
        {
            _movimiento = movimiento;
            if(movimiento != null)
            {
                LimpiarDetalleMovimiento();
                cmbProducto.SelectedValue = movimiento.IdProducto;
                cmbTipoMovimiento.SelectedItem = movimiento.TipoMovimiento;
                nudCantidadMovimiento.Value = movimiento.CantidadMovimiento;
                dtpFechaMovimiento.Value = movimiento.FechaMovimiento;
                txtObservacion.Text = movimiento.Observacion;
            }
        }

        private bool ValidarCampos(Guna2ComboBox combo, Guna2TextBox texto, Guna2NumericUpDown numerico, Guna2DateTimePicker fecha)
        {
            bool validar = true;
            errorMovimiento.Clear();


            if (int.Parse(combo.SelectedValue.ToString()) < 0)
            {
                errorMovimiento.SetError(combo, "Seleccione una opcion valida.");
                validar = false;
            }


            if (string.IsNullOrWhiteSpace(texto.Text))
            {
                errorMovimiento.SetError(texto, "Complete el campo.");
                validar = false;
            }

            if(numerico.Value == 0)
            {
                errorMovimiento.SetError(numerico, "La cantidad debe de ser mayor que 0.");
                validar = false;
            }

            if(fecha.Value.Date < DateTime.Now.Date)
            {
                errorMovimiento.SetError(fecha, "Digite una fecha mayor");
                validar = false;
            }
            return validar;
        }

        private void DetalleMovimiento_Load(object sender, EventArgs e)
        {
            CargarComboBoxProducto();
            CargarComboBoxTipoMovimiento();
            if(_movimiento != null)
            {
                CargarDetalleMovimiento(_movimiento);
            }
            else
            {
                dtpFechaMovimiento.Value = DateTime.Now;
            }
        }

        private void CargarComboBoxProducto()
        {
            List<Producto> productos = _capaNegocio.ListarProductos();
            productos.Insert(0, new Producto
            {
                IdProducto = -1,
                NombreProducto = "Seleccione un producto."
            });

            cmbProducto.DisplayMember = "NombreProducto";
            cmbProducto.ValueMember = "IdProducto";
            cmbProducto.DataSource = productos;
        }

        private void CargarComboBoxTipoMovimiento()
        {
            List<string> tipoMovimiento = new List<string> {"Entrada", "Salida"};

            cmbTipoMovimiento.DataSource = tipoMovimiento;
        }

        private void LimpiarDetalleMovimiento()
        {
            cmbProducto.SelectedValue = -1;
            cmbTipoMovimiento.SelectedItem = "Entrada";
            nudCantidadMovimiento.Value = 0;
            dtpFechaMovimiento.Value = DateTime.Now;
            txtObservacion.Text = string.Empty;
        }
    }
}
