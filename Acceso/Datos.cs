using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using Entidades;

namespace Acceso
{
    public class Datos
    {
        #region Atributos

        public string cadenaconexion = ConfigurationManager.ConnectionStrings["cnxString"].ToString();
        public SqlConnection objconexion;

        #endregion

        #region Constructor

        public Datos()
        {
            try
            {
                objconexion = new SqlConnection(cadenaconexion);
                this.CrearConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        #endregion

        #region Metodos privados

        private void CrearConexion()
        {
            if (objconexion.State == System.Data.ConnectionState.Closed)
                objconexion.Open();
        }

        private void CerrarConexion()
        {
            if (objconexion.State == System.Data.ConnectionState.Open)
                objconexion.Close();
        }

        #endregion

        #region Metodos publicos

        public int EjecutarPeticiones(SQLSentencia P_Sentencia)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(); 
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia; 
                this.CrearConexion();

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<UsuariosPorPerfiles> ConsultarUsuariosPorPerfiles(SQLSentencia P_Sentencia)
        {
            List<UsuariosPorPerfiles> lstresultados = new List<UsuariosPorPerfiles>();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion; 
                cmd.CommandText = P_Sentencia.Sentencia; 
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        UsuariosPorPerfiles u = new UsuariosPorPerfiles
                        {
                            Usuarios = new Usuarios
                            {
                                Identificacion = item.ItemArray[0].ToString(),
                                Nombre = item.ItemArray[1].ToString(),
                                Usuario = item.ItemArray[2].ToString(),
                                Clave = item.ItemArray[3].ToString(),
                                CodEstado = Convert.ToInt32(item.ItemArray[4])
                            },
                            Perfiles = new Perfiles
                            {
                                Codigo_Perfil = Convert.ToInt32(item.ItemArray[5].ToString()),
                                Descripcion_Perfil = item.ItemArray[6].ToString(),
                                Estado_Perfil = Convert.ToInt32(item.ItemArray[7]),
                            },
                            Fecha_Asociacion = Convert.ToDateTime(item.ItemArray[8].ToString())
                        };

                        lstresultados.Add(u);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
            return lstresultados;
        }

        public List<Usuarios> ConsultaUsuarios(SQLSentencia P_Sentencia)
        {
            List<Usuarios> lstresultados = new List<Usuarios>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Usuarios u = new Usuarios
                        {
                            Identificacion = item.ItemArray[0].ToString(),
                            Nombre = item.ItemArray[1].ToString(),
                            Usuario = item.ItemArray[2].ToString(),
                            Clave = item.ItemArray[3].ToString(),
                            CodEstado = Convert.ToInt32(item.ItemArray[4])                            
                        };
                        lstresultados.Add(u); 
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return lstresultados;
        }

        public List<Usuarios> ConsultaMantenimientoUsuarios(SQLSentencia P_Sentencia)
        {
            List<Usuarios> lstresultados = new List<Usuarios>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Usuarios u = new Usuarios
                        {
                            Identificacion = item.ItemArray[0].ToString(),
                            Nombre = item.ItemArray[1].ToString(),
                            Primer_Apellido = item.ItemArray[2].ToString(),
                            Segundo_Apellido = item.ItemArray[3].ToString(),
                            Usuario = item.ItemArray[4].ToString(),
                            Clave = item.ItemArray[5].ToString(),
                            CodEstado = Convert.ToInt32(item.ItemArray[6]),
                            Rol = (item.ItemArray[7].ToString()),
                            TempClave = Convert.ToInt32(item.ItemArray[8]),
                            Correo = (item.ItemArray[9].ToString())
                        };
                        lstresultados.Add(u);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return lstresultados;
        }

        public List<Aulas> ConsultaMantenimientoAulas(SQLSentencia P_Sentencia)
        {
            List<Aulas> lstresultados = new List<Aulas>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Aulas a = new Aulas
                        {
                            CodigoAula = Convert.ToInt32(item.ItemArray[0]),
                            DescAulas = item.ItemArray[1].ToString(),
                            EstAula = Convert.ToInt32(item.ItemArray[2]),
                        };
                        lstresultados.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return lstresultados;
        }

        public List<Carreras> ConsultaMantenimientoCarreras(SQLSentencia P_Sentencia)
        {
            List<Carreras> lstresultados = new List<Carreras>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Carreras a = new Carreras
                        {
                            CodigoCarrera = Convert.ToInt32(item.ItemArray[0]),
                            DescCarrera = item.ItemArray[1].ToString(),
                            EstCarrera = Convert.ToInt32(item.ItemArray[2]),
                        };
                        lstresultados.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return lstresultados;
        }

        public List<Materias> ConsultaMantenimientoMaterias(SQLSentencia P_Sentencia)
        {
            List<Materias> lstresultados = new List<Materias>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Materias a = new Materias
                        {
                            CodigoMateria = Convert.ToInt32(item.ItemArray[0]),
                            DescMateria = item.ItemArray[1].ToString(),
                            EstMateria = Convert.ToInt32(item.ItemArray[2]),
                            CodigoCarrera = Convert.ToInt32(item.ItemArray[3]),
                            DescCarrera = item.ItemArray[4].ToString(),
                        };
                        lstresultados.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return lstresultados;
        }

        public List<Profesores> ConsultaMantenimientoProfesores(SQLSentencia P_Sentencia)
        {
            List<Profesores> lstresultados = new List<Profesores>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Profesores a = new Profesores
                        {
                            Identificacion = (item.ItemArray[0].ToString()),
                            Nombre = item.ItemArray[1].ToString(),
                            Primer_Apellido = (item.ItemArray[2].ToString()),
                            Segundo_Apellido = (item.ItemArray[3].ToString()),
                            CodMateria = Convert.ToInt32(item.ItemArray[4]),
                            DescMateria = (item.ItemArray[5].ToString()),
                            CodEstado = Convert.ToInt32(item.ItemArray[6]),
                        };
                        lstresultados.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return lstresultados;
        }

        public List<RPTAulas> ConsultaRPTAulas(SQLSentencia P_Sentencia)
        {
            List<RPTAulas> lstresultados = new List<RPTAulas>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        RPTAulas a = new RPTAulas
                        {
                            CodigoAula = Convert.ToInt32(item.ItemArray[0]),
                            DescAulas = item.ItemArray[1].ToString(),
                            EstAula = (item.ItemArray[2].ToString()),
                        };
                        lstresultados.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return lstresultados;
        }

        public DataTable ConsultaInformacion(SQLSentencia P_Sentencia)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return dt;
        }

        public List<Materias> ConsultaMateriasMatricula(SQLSentencia P_Sentencia)
        {
            List<Materias> lstresultados = new List<Materias>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Materias a = new Materias
                        {
                            CodigoMateria = Convert.ToInt32(item.ItemArray[0]),
                            DescMateria = item.ItemArray[1].ToString(),
                            EstMateria = Convert.ToInt32(item.ItemArray[2]),
                        };
                        lstresultados.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return lstresultados;
        }

        public List<Profesores> ConsultaProfesoresMatricula(SQLSentencia P_Sentencia)
        {
            List<Profesores> lstresultados = new List<Profesores>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Profesores a = new Profesores
                        {
                            CodProfesor = Convert.ToInt32(item.ItemArray[0]),
                            Identificacion = item.ItemArray[1].ToString(),
                            Nombre = item.ItemArray[2].ToString(),
                            CodEstado = Convert.ToInt32(item.ItemArray[3]),
                        };
                        lstresultados.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return lstresultados;
        }

        public List<Matricula> ConsultaMatricula(SQLSentencia P_Sentencia)
        {
            List<Matricula> lstresultados = new List<Matricula>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Matricula a = new Matricula
                        {
                            CodMatricula = Convert.ToInt32(item.ItemArray[0]),
                            Identificacion = item.ItemArray[1].ToString(),
                            CodCarrera = Convert.ToInt32(item.ItemArray[2]),
                            Carrera = item.ItemArray[3].ToString(),
                            CodMateria = Convert.ToInt32(item.ItemArray[4]),
                            Materia = item.ItemArray[5].ToString(),
                            CodProfesor = Convert.ToInt32(item.ItemArray[6]),
                            Profesor = item.ItemArray[7].ToString(),
                            Estado = (item.ItemArray[8].ToString()),
                        };
                        lstresultados.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return lstresultados;
        }

        public string ObtenerCorreoUsuario(SQLSentencia P_Sentencia)
        {
            String correo = "";
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        correo = item.ItemArray[0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return correo;
        }

        public int ObtenerEstadoClave(SQLSentencia P_Sentencia)
        {
            int estadoClave = 0;
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = objconexion;
                cmd.CommandText = P_Sentencia.Sentencia;
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        estadoClave = Convert.ToInt32(item.ItemArray[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
            return estadoClave;
        }
        #endregion
    }
}
