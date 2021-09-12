using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class frmCambioContrasena : Form
    {
        public string Usuario { get; set; }

        public frmCambioContrasena()
        {
            InitializeComponent();
        }

        private void frmCambioContrasena_Load(object sender, EventArgs e)
        {
            lblCedulaSesion.Text = Usuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                // boton que muestra el formulario del registro y cierra el actual
                frmLogin frm = new frmLogin();
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClaveTemporal.Text == "" || txtClave.Text == "" || txtClaveConfirmar.Text == "")
                {
                    MessageBox.Show("Debe de completar los campos indicados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtClave.Text.Trim() != txtClaveConfirmar.Text.Trim())
                {
                    MessageBox.Show("La contraseña no coincide con la confirmación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Usuarios u = new Usuarios();
                    // se asignan los campos a las entidades (objetos)
                    u.Identificacion = lblCedulaSesion.Text.Trim();
                    u.Clave = txtClaveTemporal.Text.Trim();
                    if (Logica.Autenticacion(u))
                    {
                        Usuarios usu = new Usuarios();
                        usu.Identificacion = lblCedulaSesion.Text;
                        usu.Clave = txtClave.Text.Trim();
                        usu.TempClave = 0;

                        if (Gestor_Conexiones.CambioContrasena(usu) >= 1)
                        {
                            MessageBox.Show("Contraseña modificada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // boton que muestra el formulario del registro y cierra el actual
                            txtClave.Text = "";
                            txtClaveConfirmar.Text = "";
                            txtClaveTemporal.Text = "";
                            frmLogin frm = new frmLogin();
                            frm.Show();
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                    
                    }
                    else 
                    {
                        MessageBox.Show("La contraseña temporal no es correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
