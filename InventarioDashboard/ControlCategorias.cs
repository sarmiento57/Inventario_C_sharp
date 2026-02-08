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
    public partial class ControlCategorias : UserControl
    {
        private CapaNegocio _capaNegocio;
        private Categoria _categoria;
        public ControlCategorias()
        {
            InitializeComponent();
            _capaNegocio = new CapaNegocio();
            _categoria = new Categoria();
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if(txtNombreCategoria.Text != "")
            {
                GuardarCategoria();
                CargarGrillaCategorias();
                UltimaCategoria();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Complete el campo Nombre.");
            }

        }

        private void GuardarCategoria()
        {
            Categoria categoria = new Categoria();
            categoria.NombreCategoria = txtNombreCategoria.Text;

            categoria.IdCategoria = _categoria != null ? _categoria.IdCategoria : 0;

            _capaNegocio.GuardarCategoria(categoria);
        }

        private void CargarFormulario(Categoria categoria)
        {
            _categoria = categoria;
            if(categoria != null)
            {
                LimpiarFormulario();
                txtNombreCategoria.Text = categoria.NombreCategoria;
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreCategoria.Text = string.Empty;
        }
        private List<Categoria> CargarGrillaCategorias()
        {
            List<Categoria> categorias = _capaNegocio.ListarCategorias();
            dgvCategoria.DataSource = categorias;
            return categorias;
        }
        private void UltimaCategoria()
        {
            List<Categoria> ultimaCategoria = _capaNegocio.ListarCategorias();
            string categoria = ultimaCategoria.LastOrDefault().NombreCategoria;

            lblUltimaCategoria.Text = ultimaCategoria.Count > 0 ? lblUltimaCategoria.Text = categoria : "No hay categorias";
        }

        private void ControlCategorias_Load(object sender, EventArgs e)
        {
            CargarGrillaCategorias();
            UltimaCategoria();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvCategoria.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            if(cell.Value.ToString() == "Editar")
            {
                CargarFormulario(new Categoria
                {
                    IdCategoria = int.Parse(dgvCategoria.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    NombreCategoria = dgvCategoria.Rows[e.RowIndex].Cells[1].Value.ToString()
                });
            }else if(cell.Value.ToString() == "Eliminar")
            {
                int id = int.Parse(dgvCategoria.Rows[e.RowIndex].Cells[0].Value.ToString());
                var mensaje = MessageBox.Show("Estas Seguro de eliminar la categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (mensaje.ToString() == "Yes")
                {
                    EliminarCategoria(id);
                    CargarGrillaCategorias();
                    UltimaCategoria();
                }
            }
        }

        private void EliminarCategoria(int id)
        {
            _capaNegocio.EliminarCategoriaId(id);
        }
    }
}
