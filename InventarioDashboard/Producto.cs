using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioDashboard
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int IdCategoria { get; set; }
        public string TallaProducto { get; set; }
        public string ColorProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int StockProducto { get; set; }

        public Producto()
        {
            
        }
        public Producto(int id, string codigo, string nombre, int idCategoria, string talla, string color,
            decimal precio, DateTime fecha, int stock)
        {
            IdProducto = id;
            CodigoProducto = codigo;
            NombreProducto = nombre;
            IdCategoria = idCategoria;
            TallaProducto = talla;
            ColorProducto = color;
            PrecioUnitario = precio;
            FechaIngreso = fecha;
            StockProducto = stock;
        }
    }
}
