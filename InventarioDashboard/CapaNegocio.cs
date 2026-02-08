using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioDashboard
{
    public class CapaNegocio
    {
        private AccesoDatos _db;

        public CapaNegocio()
        {
            _db = new AccesoDatos();
        }
        #region Categoria
        public Categoria GuardarCategoria(Categoria categoria)
        {
            if(categoria.IdCategoria == 0)
            {
                _db.InsertarCategoria(categoria);
            }
            else
            {
                _db.ActualizarCategoria(categoria);
                MessageBox.Show("Categoria actualizada correctamente");
            }
            return categoria;
        }

        public List<Categoria> ListarCategorias()
        {
            List<Categoria> categorias = _db.GetCategorias();
            return categorias;
        }

        public void EliminarCategoriaId(int id)
        {
            _db.DeleteCategoria(id);
        }
        #endregion

        #region Producto
        public Producto GuardarProducto(Producto producto)
        {
            if(producto.IdProducto == 0)
            {
                _db.InsertarProducto(producto);
            }
            else
            {
                _db.UpdateProducto(producto);
                MessageBox.Show("Producto actualizado.");
            }
            return producto;
        }

        public List<Producto> ListarProductos(string buscar = null)
        {
            List<Producto> productos = _db.GetProductos(buscar);
            return productos;
        }

        public void EliminarProducto(int id)
        {
            _db.EliminarProducto(id);
        }
        #endregion

        #region Movimiento
        public Movimiento GuardarMovimiento(Movimiento movimiento)
        {
            if(movimiento.IdMovimiento == 0)
            {
                _db.InsertarMovimiento(movimiento);
            }
            else
            {
                _db.UpdateMovimiento(movimiento);
                MessageBox.Show("Movimiento actualizado correctamente.");
            }
            return movimiento;
        }

        public List<Movimiento> ListarMovimientos(string buscar = null)
        {
            List<Movimiento> movimientos = _db.GetMovimientos(buscar);
            return movimientos;
        }

        public void EliminarMovimiento(int id)
        {
            _db.DeleteMovimiento(id);
        }
        #endregion

        #region Login
        public Usuario AccesoSistema(string user, string clave)
        {
            Usuario users = _db.ValidarAcceso(user, clave);
            return users;
        }
        #endregion
    }
}
