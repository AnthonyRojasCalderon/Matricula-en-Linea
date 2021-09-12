using Entidades;
using System;
using System.Windows.Forms;
using Negocio;
using System.Threading;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        private Correo lstCorreos { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            lstCorreos = new Correo();
        }

        private void EnviarCorreo(string Asunto, string Mensaje, string Remitente)
        {
            lstCorreos.Asunto = Asunto;
            lstCorreos.Cuerpo = Mensaje;
            lstCorreos.Remitente = Remitente;
            lstCorreos.Destinatarios = Remitente;

            Gestor_Conexiones.EnvioCorreo(lstCorreos);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no esten vacíos
                if (txtUsuario.Text.Equals("") || txtClave.Text.Equals("")) 
                {
                    progressBar.Visible = false;
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { 
                int y = 0;
                Usuarios u = new Usuarios();
                // se asignan los campos a las entidades (objetos)
                u.Identificacion = txtUsuario.Text.Trim();
                u.Clave = txtClave.Text.Trim();

                // se inicia la barra de progreso
                progressBar.Visible = true;
                progressBar.Minimum = 1;
                progressBar.Maximum = 10000;
                progressBar.Value = 1;
                progressBar.Step = 1;
                
                // se envia a consumir el metodo de autenticar
                if (Logica.Autenticacion(u))
                {
                    int estadoClave = Gestor_Conexiones.ObtenerEstadoClave(u);

                    // si la respuesta es positiva
                    progressBar.Visible = true;
                    for (y = 1; y <= 10000; y++)
                    {
                        // recorre la barra
                        progressBar.PerformStep();
                    }
                        if (estadoClave == 1)
                        {
                            // se envia el formulario de Menu
                            frmCambioContrasena frm = new frmCambioContrasena();
                            frm.Usuario = txtUsuario.Text.Trim(); // se envia por método constructor el usuario
                            frm.Show();
                            this.Hide();
                        }
                        else 
                        {
                            // se envia el formulario de Menu
                            frmMenu frm = new frmMenu();
                            frm.Usuario = txtUsuario.Text.Trim(); // se envia por método constructor el usuario
                            frm.CargarOpcionesMenu(); // se carga el menu
                            frm.Show();
                            this.Hide();
                            // se cierra el formulario de Login
                        }
                    }
                else
                {
                    // datos incorrectos y no se muestra la barra de progreso 
                    progressBar.Visible = false;
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              }
            }
            catch (Exception)
            {
                // si se genera un error en el sistema y no se muestra la barra de progreso 
                progressBar.Visible = false;
                MessageBox.Show("No fue posible realizar el ingreso al sistema favor intente más tarde","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                // boton que muestra el formulario del registro y cierra el actual
                frmRegistro frm = new frmRegistro();
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // si se genera un error en el sistema y no se muestra la barra de progreso 
                progressBar.Visible = false;
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals("") || txtUsuario.Text == "" || txtUsuario.Text == " -    -")
                {
                    MessageBox.Show("Debe de colocar el número de identificación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    // https://www.kyocode.com/2018/09/generar-contrasenas-aleatorias-c/#:~:text=Al%20generar%20contrase%C3%B1as%20aleatorias%20en,%2C%20letras%2C%20caracteres%2C%20etc.
                    Random rdn = new Random();
                    string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
                    int longitud = caracteres.Length;
                    char letra;
                    int longitudContrasenia = 10;
                    string contraseniaAleatoria = string.Empty;
                    for (int i = 0; i < longitudContrasenia; i++)
                    {
                        letra = caracteres[rdn.Next(longitud)];
                        contraseniaAleatoria += letra.ToString();
                    }

                    Usuarios u = new Usuarios();
                    u.Identificacion = txtUsuario.Text;
                    u.Clave = contraseniaAleatoria;
                    u.TempClave = 1;

                    if (Gestor_Conexiones.CambioContrasena(u) == 1)
                    {
                        string correo = Gestor_Conexiones.ObtenerCorreoUsuario(u);
                        string asunto = "Clave Temporal Matricula en Linea";
                        string mensaje = "Su nueva clave temporal es: " + contraseniaAleatoria;
                        EnviarCorreo(asunto, mensaje, correo);
                        MessageBox.Show("Contraseña modificada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                // si se genera un error en el sistema y no se muestra la barra de progreso 
                progressBar.Visible = false;
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
