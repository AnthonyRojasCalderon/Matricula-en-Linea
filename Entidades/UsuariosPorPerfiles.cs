using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuariosPorPerfiles  
    {        
        public Usuarios Usuarios { get; set; }
        public Perfiles Perfiles { get; set; }
        public DateTime Fecha_Asociacion { get; set; }
    }
}
