using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    public class Correo
    {
        public string Asunto { get; set; }

        public string Cuerpo { get; set; }

        public string Destinatarios { get; set; }

        public string Remitente { get; set; }
    }
}
