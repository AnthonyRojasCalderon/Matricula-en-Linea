using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso;
using Entidades;
using System.Net;
using System.Net.Mail;

namespace Negocio
{
    public class Logica
    {
        #region autenticacion y autorización
        public static bool Autenticacion (Usuarios P_Usuario)
        {
            try
            {
                SQLSentencia s = new SQLSentencia();
                s.Sentencia = @"EXEC PA_Autenticacion '" + P_Usuario.Identificacion + "','" + P_Usuario.Clave + "'";
                Datos objacceso = new Datos();
                List<Usuarios> lstusuarios = objacceso.ConsultaUsuarios(s);

                if (lstusuarios.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        public static List<UsuariosPorPerfiles> Autorizacion (Usuarios P_Usuario)
        {
            try
            {
                SQLSentencia s = new SQLSentencia();
                s.Sentencia = @"EXEC PA_AutorizacionUsuario '" + P_Usuario.Identificacion + "'";
                Datos objacceso = new Datos();
                return objacceso.ConsultarUsuariosPorPerfiles(s);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int IngresarUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Ingresar_Usuario '" + P_Usuario.Identificacion + "','" + P_Usuario.Nombre + "','" + P_Usuario.Primer_Apellido + "','" + P_Usuario.Segundo_Apellido + "','" + P_Usuario.Usuario + "','" + P_Usuario.Clave + "','" + P_Usuario.CodEstado + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Usuarios> ConsultaUsuarios()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();

                objsentencia.Sentencia = @"EXEC PA_ConsultarUsuarios";

                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoUsuarios(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Ingresar_Mant_Usuario(Usuarios P_Usuario)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Ingresar_Mant_Usuario '" + P_Usuario.Identificacion + "','" + P_Usuario.Nombre + "','" + P_Usuario.Primer_Apellido + "','" + P_Usuario.Segundo_Apellido + "','" + P_Usuario.Usuario + "','" + P_Usuario.Clave + "','" + P_Usuario.CodEstado + "', '"+P_Usuario.Rol+"', '" +P_Usuario.Correo+ "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Eliminar_Mant_Usuario(Usuarios P_Usuario)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Eliminar_Mant_Usuario '" + P_Usuario.Identificacion + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Modificar_Mant_Usuario(Usuarios P_Usuario)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Modificar_Mant_Usuario '" + P_Usuario.Identificacion + "','" + P_Usuario.Nombre + "','" + P_Usuario.Primer_Apellido + "','" + P_Usuario.Segundo_Apellido + "','" + P_Usuario.Usuario + "','" + P_Usuario.Clave + "','" + P_Usuario.CodEstado + "', '" + P_Usuario.Rol + "', '"+P_Usuario.Correo+"'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Aulas
        public static List<Aulas> ConsultaAulas()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultarAulas";
                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoAulas(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Ingresar_Mant_Aulas(Aulas P_Aula)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Ingresar_Mant_Aulas '" + P_Aula.CodigoAula+ "','" + P_Aula.DescAulas+ "','" + P_Aula.EstAula + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Eliminar_Mant_Aulas(Aulas P_Aula)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Eliminar_Mant_Aula '" + P_Aula.CodigoAula + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Modificar_Mant_Aulas(Aulas P_Aula)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Modificar_Mant_Aula '" + P_Aula.CodigoAula+ "', '"+P_Aula.DescAulas+"', '"+P_Aula.EstAula+"'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Carreras
        public static List<Carreras> ConsultaCarreras()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultarCarreras";
                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoCarreras(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Ingresar_Mant_Carreras(Carreras P_Carreras)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Ingresar_Mant_Carreras '" + P_Carreras.CodigoCarrera + "','" + P_Carreras.DescCarrera + "','" + P_Carreras.EstCarrera+ "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Eliminar_Mant_Carreras(Carreras P_Carreras)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Eliminar_Mant_Carrera '" + P_Carreras.CodigoCarrera + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Modificar_Mant_Carreras(Carreras P_Carreras)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Modificar_Mant_Carrera '" + P_Carreras.CodigoCarrera + "', '" + P_Carreras.DescCarrera + "', '" + P_Carreras.EstCarrera + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Materias
        public static List<Materias> ConsultaMaterias()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultarMaterias";
                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoMaterias(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Ingresar_Mant_Materias(Materias P_Materias)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Ingresar_Mant_Materias '" + P_Materias.CodigoMateria+ "','" + P_Materias.DescMateria + "','" + P_Materias.EstMateria + "','"+P_Materias.CodigoCarrera+"'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Eliminar_Mant_Materias(Materias P_Materias)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Eliminar_Mant_Materia '" + P_Materias.CodigoMateria + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int Modificar_Mant_Materias(Materias P_Materias)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Modificar_Mant_Materias '" + P_Materias.CodigoMateria + "','" + P_Materias.DescMateria + "','" + P_Materias.EstMateria + "','" + P_Materias.CodigoCarrera + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Profesores
        public static List<Profesores> ConsultaProfesores()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultarProfesores";
                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoProfesores(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Ingresar_Mant_Profesores(Profesores P_Profesores)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Ingresar_Mant_Profesores '" + P_Profesores.Identificacion + "','" + P_Profesores.Nombre + "','" + P_Profesores.Primer_Apellido + "','" + P_Profesores.Segundo_Apellido + "','"+ P_Profesores.CodMateria+ "','"+P_Profesores.CodEstado+"'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Eliminar_Mant_Profesores(Profesores P_Profesores)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Eliminar_Mant_Profesor '" + P_Profesores.Identificacion + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Modificar_Mant_Profesores(Profesores P_Profesores)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Modificar_Mant_Profesores '" + P_Profesores.Identificacion + "','" + P_Profesores.Nombre + "','" + P_Profesores.Primer_Apellido + "','" + P_Profesores.Segundo_Apellido + "','" + P_Profesores.CodMateria + "','" + P_Profesores.CodEstado + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         #endregion

        #region Reportes
        public static List<Usuarios> ConsultaUsuariosActivos()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();

                objsentencia.Sentencia = @"EXEC PA_RPT_UsuariosActivos";

                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoUsuarios(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Usuarios> ConsultaUsuariosInactivos()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();

                objsentencia.Sentencia = @"EXEC PA_RPT_UsuariosInactivos";

                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoUsuarios(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Profesores> ConsultaProfesoresActivos()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();

                objsentencia.Sentencia = @"EXEC PA_RPT__ProfesoresActivos";

                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoProfesores(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Profesores> ConsultaProfesoresInactivos()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();

                objsentencia.Sentencia = @"EXEC PA_RPT__ProfesoresInactivos";

                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoProfesores(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<RPTAulas> ConsultaAulasEstados()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();

                objsentencia.Sentencia = @"EXEC PA_RPT_ConsultarAulasEstados";

                Datos objacceso = new Datos();
                return objacceso.ConsultaRPTAulas(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Matricula> ConsultaMatriculadas()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();

                objsentencia.Sentencia = @"EXEC PA_RPT_Matriculadas";

                Datos objacceso = new Datos();
                return objacceso.ConsultaMatricula(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Matricula> ConsultaCongeladas()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();

                objsentencia.Sentencia = @"EXEC PA_RPT_Congeladas";

                Datos objacceso = new Datos();
                return objacceso.ConsultaMatricula(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Usuarios> ConsultaUsuariosEstado_x_Usuario()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();

                objsentencia.Sentencia = @"EXEC PA_ConsultarUsuarios_X_Estado_Clave";

                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoUsuarios(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Usuarios> ConsultaUsuariosEstado_x_Usuario_C()
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultarUsuarios_X_Estado_Clave_C";
                Datos objacceso = new Datos();
                return objacceso.ConsultaMantenimientoUsuarios(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Matricula
        public static DataTable ConsultaInformacion(string param)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultarInformacion '"+ param + "'";
                Datos objacceso = new Datos();
                return objacceso.ConsultaInformacion(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Materias> ConsultaMaterias_x_Carrera(int parametro)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultarMaterias_x_Carrera '"+parametro+"'";
                Datos objacceso = new Datos();
                return objacceso.ConsultaMateriasMatricula(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Profesores> ConsultaPofesores_x_Materia(int parametro)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultarProfesores_x_Materia '" + parametro + "'";
                Datos objacceso = new Datos();
                return objacceso.ConsultaProfesoresMatricula(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Matricula> ConsultaMatricula(string ced)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultarMatricula '"+ced+"'";
                Datos objacceso = new Datos();
                return objacceso.ConsultaMatricula(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Ingresar_Matricula(Matricula P_Matricula)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Ingresar_Matricula '" + P_Matricula.Identificacion + "','" + P_Matricula.CodCarrera + "','" + P_Matricula.CodMateria + "','" + P_Matricula.CodProfesor + "'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Modificar_Matricula(Matricula P_Matricula)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Modificar_Matricula '" + P_Matricula.CodMatricula + "', '"+P_Matricula.Estado+"'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ModificarContraseña
        public static string ObtenerCorreoUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultaCorreo_Usuario'" + P_Usuario.Identificacion + "'";
                Datos objacceso = new Datos();
                return objacceso.ObtenerCorreoUsuario(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Modificar_Pass_Usuario(Usuarios P_Usuario)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = "EXEC PA_Modificar_Pass_Usuario '" + P_Usuario.Identificacion + "','" + P_Usuario.Clave + "','"+P_Usuario.TempClave+"'";
                Datos objacceso = new Datos();
                return objacceso.EjecutarPeticiones(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool EnvioCorreo(Correo P_Correo)
        {
            MailMessage mensaje = null;
            SmtpClient envio = null;
            try
            {
                mensaje = new MailMessage();
                mensaje.From = new MailAddress(P_Correo.Remitente, P_Correo.Remitente);
                mensaje.To.Add(new MailAddress(P_Correo.Destinatarios));
                mensaje.Subject = P_Correo.Asunto;
                mensaje.Body = P_Correo.Cuerpo;
                mensaje.IsBodyHtml = true;
                mensaje.Priority = MailPriority.Normal;
                envio = new SmtpClient();
                envio.Host = "smtp.gmail.com";
                envio.Port = 587;
                envio.EnableSsl = true;
                envio.UseDefaultCredentials = false;
                envio.Credentials = new NetworkCredential("joeluamcr@gmail.com", "Uam12345678");
                try
                {
                    envio.Send(mensaje);
                    mensaje.Dispose();
                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public static int ObtenerEstadoClave(Usuarios P_Usuario)
        {
            try
            {
                SQLSentencia objsentencia = new SQLSentencia();
                objsentencia.Sentencia = @"EXEC PA_ConsultaEstadoClave_Usuario'" + P_Usuario.Identificacion + "'";
                Datos objacceso = new Datos();
                return objacceso.ObtenerEstadoClave(objsentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
