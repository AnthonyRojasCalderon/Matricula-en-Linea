﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesores
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public int CodMateria { get; set; }
        public string DescMateria { get; set; }
        public int CodEstado { get; set; }
        public int CodProfesor { get; set; }
    }
}
