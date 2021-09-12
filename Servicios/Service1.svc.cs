using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;
using Negocio;

namespace Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string ObtenerCorreoUsuario(Usuarios P_Usuario)
        {
            return Logica.ObtenerCorreoUsuario(P_Usuario);
        }

        public int CambioContrasena(Usuarios P_Usuario)
        {
            return Logica.Modificar_Pass_Usuario(P_Usuario);
        }

        public bool EnvioCorreo(Correo P_Correo)
        {
            return Logica.EnvioCorreo(P_Correo);
        }

        public int ObtenerEstadoClave(Usuarios P_Usuario)
        {
            return Logica.ObtenerEstadoClave(P_Usuario);
        }
    }
}
