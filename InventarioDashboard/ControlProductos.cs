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
    public partial class ControlProductos : UserControl
    {
        private CapaNegocio _capaNegocio;
        public ControlProductos()
        {
            InitializeComponent();
            _capaNegocio = new CapaNegocio();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormDetalleProducto();
        }
        private void AbrirFormDetalleProducto()
        {
            DetalleProducto detalleProducto = new DetalleProducto(this);
            detalleProducto.ShowDialog();
        }

        private void ControlProductos_Load(object sender, EventArgs e)
        {
            CargarGrillaProductos();
        }

        public List<Producto> CargarGrillaProductos(string buscar = null)
        {
            List<Producto> productos = _capaNegocio.ListarProductos(buscar);
            dgvProductos.DataSource = productos;
            return productos;
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].DataPropertyName == "IdCategoria")
            {
                int idCategoria = int.Parse(dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString());
                var categorias = _capaNegocio.ListarCategorias();

                var categoria = categorias.FirstOrDefault(c => c.IdCategoria == idCategoria);

                if(categoria != null)
                {
                    e.Value = categoria.NombreCategoria;
                }
                else
                {
                    e.Value = idCategoria;
                }
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DetalleProducto detalleProducto = new DetalleProducto(this);

            if(cell.Value.ToString() == "Editar")
            {
                detalleProducto.CargarDatosDetalleProducto(new Producto
                {
                    IdProducto = int.Parse(dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    CodigoProducto = dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    NombreProducto = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    IdCategoria = int.Parse(dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    TallaProducto = dgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    ColorProducto = dgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    PrecioUnitario = decimal.Parse(dgvProductos.Rows[e.RowIndex].Cells[6].Value.ToString()),
                    FechaIngreso = (DateTime)dgvProductos.Rows[e.RowIndex].Cells[7].Value,
                    StockProducto = int.Parse(dgvProductos.Rows[e.RowIndex].Cells[8].Value.ToString())
                });

                detalleProducto.Show();
            }else if(cell.Value.ToString() == "Eliminar")
            {
                int id = int.Parse(dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
                var mensaje = MessageBox.Show("Confirmar", "Estas seguro de eliminar el producto.?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(mensaje.ToString() == "Yes")
                {
                    EliminarProductoId(id);
                    CargarGrillaProductos();
                }
            }
        }

        private void EliminarProductoId(int id)
        {
            _capaNegocio.EliminarProducto(id);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            CargarGrillaProductos(txtBuscarProducto.Text);
        }
    }
}
