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
    public partial class ControlMovimientos : UserControl
    {
        private CapaNegocio _capaNegocio;
        public ControlMovimientos()
        {
            InitializeComponent();
            _capaNegocio = new CapaNegocio();
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            AbrirDetalleMovimiento();
        }
        private void AbrirDetalleMovimiento()
        {
            DetalleMovimiento detalle = new DetalleMovimiento(this);
            detalle.ShowDialog();
        }

        private void ControlMovimientos_Load(object sender, EventArgs e)
        {
            CargarGrillaMovimiento();
        }

        public List<Movimiento> CargarGrillaMovimiento(string buscar = null)
        {
            List<Movimiento> movimientos = _capaNegocio.ListarMovimientos(buscar);
            dgvMovimiento.DataSource = movimientos;
            return movimientos;
        }

        private void dgvMovimiento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMovimiento.Columns[e.ColumnIndex].DataPropertyName == "IdProducto")
            {
                int idProducto = int.Parse(dgvMovimiento.Rows[e.RowIndex].Cells[1].Value.ToString());
                var productos = _capaNegocio.ListarProductos();
                var producto = productos.FirstOrDefault(p => p.IdProducto == idProducto);

                if(producto != null)
                {
                    e.Value = producto.NombreProducto;
                }
                else
                {
                    e.Value = idProducto;
                }
            }
        }

        private void dgvMovimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvMovimiento.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DetalleMovimiento detalleMovimiento = new DetalleMovimiento(this);

            if(cell.Value.ToString() == "Editar")
            {
                detalleMovimiento.CargarDetalleMovimiento(new Movimiento
                {
                    IdMovimiento = int.Parse(dgvMovimiento.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    IdProducto = int.Parse(dgvMovimiento.Rows[e.RowIndex].Cells[1].Value.ToString()),
                    TipoMovimiento = dgvMovimiento.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    CantidadMovimiento = int.Parse(dgvMovimiento.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    FechaMovimiento = (DateTime)dgvMovimiento.Rows[e.RowIndex].Cells[4].Value,
                    Observacion = dgvMovimiento.Rows[e.RowIndex].Cells[5].Value.ToString(),
                });
                detalleMovimiento.ShowDialog();
            }else if(cell.Value.ToString() == "Eliminar")
            {
                int id = int.Parse(dgvMovimiento.Rows[e.RowIndex].Cells[0].Value.ToString());
                var mensaje = MessageBox.Show("Confirmar", "Estas seguro de eliminar el movimiento.?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (mensaje.ToString() == "Yes")
                {
                    EliminarMovimientoId(id);
                    CargarGrillaMovimiento();
                }
            }
        }
        private void EliminarMovimientoId(int id)
        {
            _capaNegocio.EliminarMovimiento(id);
        }

        private void btnBuscarMovimiento_Click(object sender, EventArgs e)
        {
            CargarGrillaMovimiento(txtBuscarMovimiento.Text);
        }
    }
}
