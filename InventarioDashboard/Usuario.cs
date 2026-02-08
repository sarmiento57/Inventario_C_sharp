using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioDashboard
{
    public class Usuario
    {
        public string Users { get; set; }
        public string NombreUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string Rol { get; set; }
        public string Clave { get; set; }

        public Usuario()
        {
            
        }

        public Usuario(string user, string nombre, string email, string rol, string clave)
        {
            Users = user;
            NombreUsuario = nombre;
            EmailUsuario = email;
            Rol = rol;
            Clave = clave;
        }
    }
}
