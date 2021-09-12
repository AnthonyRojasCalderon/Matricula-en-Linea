using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;

namespace Servicios
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string ObtenerCorreoUsuario(Usuarios P_Usuario);

        [OperationContract]
        int CambioContrasena(Usuarios P_Usuario);

        [OperationContract]
        bool EnvioCorreo(Correo P_Correo);

        [OperationContract]
        int ObtenerEstadoClave(Usuarios P_Usuario);
    }
}
