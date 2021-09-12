using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int CodEstado { get; set; }
        public string Rol { get; set; }
        public int TempClave { get; set; }
        public string Correo { get; set; }
    }
}
