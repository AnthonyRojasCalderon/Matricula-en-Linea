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
    public partial class frmMenu : Form
    {
        public string Usuario { get; set; }

        public frmMenu()
        {
            InitializeComponent();
        }

        public void CargarOpcionesMenu()
        {
            try
            {
                //Coloca el nombre del usuario logueado en la parte inferior
                tssl_nomusuario.Text = Usuario;

                //Crea objeto usuario y le asigna la propiedad Usuario con el usuario autenticado
                Usuarios u = new Usuarios();
                u.Nombre = Usuario;
                u.Identificacion = Usuario;

                //Consulta permisos del usuario asignado
                List<UsuariosPorPerfiles> lstpermisos = Logica.Autorizacion(u);

                //Deshabilita las opciones del menu
                mantenimientoToolStripMenuItem.Visible = false;
                procesosToolStripMenuItem.Visible = false;
                consultasToolStripMenuItem.Visible = false;
                sistemaToolStripMenuItem.Visible = true;

                //Aqui recorro los permisos consultados
                foreach (UsuariosPorPerfiles item in lstpermisos)
                {
                    switch(item.Perfiles.Codigo_Perfil)
                    {
                        case 1: { mantenimientoToolStripMenuItem.Visible = true;
                                consultasToolStripMenuItem.Visible = true;} break;
                        case 2: { procesosToolStripMenuItem.Visible = true;
                                consultasToolStripMenuItem.Visible = true;} break;
                        case 3: { consultasToolStripMenuItem.Visible = true;  } break;
                        case 4: { } break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cerrarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
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

        private void frmMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                frmUsuarios frm = new frmUsuarios();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void usuariosPorPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                frmAulas frm = new frmAulas();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                frmMaterias frm = new frmMaterias();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                frmCarreras frm = new frmCarreras();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                frmProfesores frm = new frmProfesores();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registraVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                frmMatriculaEstudiante frm = new frmMatriculaEstudiante();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                RptUsuarios frm = new RptUsuarios();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listadoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                rptProfesores frm = new rptProfesores();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aulasPorEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                RptEstadoAulas frm = new RptEstadoAulas();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrarNotaDebitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                frmCongelarEstudiante frm = new frmCongelarEstudiante();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materiasMatriculadasYCongeladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                RptMaterias frm = new RptMaterias();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clavesTemporalesYActivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se retorna al formulario de Login y se cierra el actual (Cierre de sesion)
                rptUsuario_x_Clave frm = new rptUsuario_x_Clave();
                frm.Usuario = tssl_nomusuario.Text.Trim(); // se envia por método constructor el usuario
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
