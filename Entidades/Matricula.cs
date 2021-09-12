using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Matricula
    {
        public int CodMatricula { get; set; }
        public string Identificacion { get; set; }
        public int CodCarrera { get; set; }
        public string Carrera { get; set; }
        public int CodMateria { get; set; }
        public string Materia { get; set; }
        public int CodProfesor { get; set; }
        public string Profesor { get; set; }
        public string Estado { get; set; }
    }
}
