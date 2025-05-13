using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int NumIntentosFallidos { get; set; }
        public bool EstadoCuenta { get; set; }
        public DateTime? FechaBloqueo { get; set; }
    }
}
