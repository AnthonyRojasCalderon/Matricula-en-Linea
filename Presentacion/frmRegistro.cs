using System;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Boton que limpia el formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdentificacion.Text = "";
                txtNombre.Text = "";
                txtPrimerApellido.Text = "";
                txtSegundoApellido.Text = "";
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtConfirmarClave.Text = "";
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (txtIdentificacion.Text.Equals("") || txtNombre.Text.Equals("")
                    || txtPrimerApellido.Text.Equals("") || txtSegundoApellido.Text.Equals("")
                    || txtUsuario.Text.Equals("")
                    || txtClave.Text.Equals("") || txtConfirmarClave.Text.Equals(""))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtClave.Text.Trim() != txtConfirmarClave.Text.Trim())
                {
                    // se valida la igualdad de los campos ... el Trim para no guardar espacios vacios en BD
                    MessageBox.Show("La contraseña no coincide con la confirmación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    Usuarios u = new Usuarios();
                    Perfiles p = new Perfiles();
                    UsuariosPorPerfiles up = new UsuariosPorPerfiles();
                    // Asignacion de los objetos
                    u.Identificacion = txtIdentificacion.Text.Trim();
                    u.Nombre = txtNombre.Text.Trim();
                    u.Primer_Apellido = txtPrimerApellido.Text.Trim();
                    u.Segundo_Apellido = txtSegundoApellido.Text.Trim();
                    u.Usuario = txtUsuario.Text.Trim();
                    u.Clave = txtClave.Text.Trim();
                    u.CodEstado = 1;

                    // Se consume el metodo de registro
                    if (Logica.IngresarUsuario(u) > 0)
                    {
                        MessageBox.Show("Usuario Registrado con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIdentificacion.Text = "";
                        txtNombre.Text = "";
                        txtPrimerApellido.Text = "";
                        txtSegundoApellido.Text = "";
                        txtUsuario.Text = "";
                        txtClave.Text = "";
                        txtConfirmarClave.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No fue posible realizar el registro por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el registro por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
