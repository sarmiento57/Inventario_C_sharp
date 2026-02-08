using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioDashboard
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        public int IdProducto { get; set; }
        public string TipoMovimiento { get; set; }
        public int CantidadMovimiento { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string Observacion { get; set; }

        public Movimiento()
        {
            
        }

        public Movimiento(int id, int idproducto, string tipo, int cantidad, DateTime fecha, string observacion)
        {
            IdMovimiento = id;
            IdProducto = idproducto;
            TipoMovimiento = tipo;
            CantidadMovimiento = cantidad;
            FechaMovimiento = fecha;
            Observacion = observacion;
        }

    }
}
