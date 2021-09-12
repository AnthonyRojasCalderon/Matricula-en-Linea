using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Presentacion
{
    public class Gestor_Conexiones
    {
        public static string ObtenerCorreoUsuario(Usuarios P_Usuario)
        {
            WCFService.Service1Client objconexion = null;

            try
            {
                objconexion = new WCFService.Service1Client();
                return objconexion.ObtenerCorreoUsuario(P_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objconexion != null)
                    objconexion.Close();
            }
        }

        public static int CambioContrasena(Usuarios P_Usuario)
        {
            WCFService.Service1Client objconexion = null;

            try
            {
                objconexion = new WCFService.Service1Client();
                return objconexion.CambioContrasena(P_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objconexion != null)
                    objconexion.Close();
            }
        }

        public static bool EnvioCorreo(Correo P_Correo)
        {
            WCFService.Service1Client objservicio = null;

            try
            {
                objservicio = new WCFService.Service1Client();
                return objservicio.EnvioCorreo(P_Correo);
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();
            }
        }

        public static int ObtenerEstadoClave(Usuarios P_Usuario)
        {
            WCFService.Service1Client objconexion = null;

            try
            {
                objconexion = new WCFService.Service1Client();
                return objconexion.ObtenerEstadoClave(P_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objconexion != null)
                    objconexion.Close();
            }
        }


    }
}
