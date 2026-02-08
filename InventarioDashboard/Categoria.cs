using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioDashboard
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public Categoria()
        {
            
        }

        public Categoria(int id, string nombre)
        {
            IdCategoria = id;
            NombreCategoria = nombre;
        }
    }
}
