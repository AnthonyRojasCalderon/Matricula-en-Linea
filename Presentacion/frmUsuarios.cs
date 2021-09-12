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
    public partial class frmUsuarios : Form
    {
        public string Usuario { get; set; }

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            lblCedulaSesion.Text = Usuario;
            CargarListado();
            CargarPerfil();
            CargarEstado();
        }

        public List<Usuarios> lstUsuarios { get; set; }
       
        private void CargarListado()
        {
            try
            {
                lstUsuarios = Logica. ConsultaUsuarios();
                dGridUsuario.DataSource = lstUsuarios;
                dGridUsuario.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        private void CargarPerfil()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");

            dt.Rows.Add("-1", "Seleccione");
            dt.Rows.Add("1", "Funcionario");
            dt.Rows.Add("2", "Estudiante");

            cboPerfil.DataSource = dt;
            cboPerfil.ValueMember = "Codigo";
            cboPerfil.DisplayMember = "Descripcion";
            cboPerfil.SelectedIndex = 0;
            cboPerfil.Refresh();
        }
        
        private void CargarEstado()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");

            dt.Rows.Add("-1", "Seleccione");
            dt.Rows.Add("1", "Activo");
            dt.Rows.Add("2", "Inactivo");

            cboEstado.DataSource = dt;
            cboEstado.ValueMember = "Codigo";
            cboEstado.DisplayMember = "Descripcion";
            cboEstado.SelectedIndex = 0;
            cboEstado.Refresh();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                // se envia el formulario de Menu
                frmMenu frm = new frmMenu();
                frm.Usuario = lblCedulaSesion.Text; // se envia por método constructor el usuario
                frm.CargarOpcionesMenu(); // se carga el menu
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                cboEstado.SelectedValue = "-1";
                cboPerfil.SelectedValue = "-1";
                txtCorreo.Text = "";
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
                    || txtCorreo.Text.Equals("")
                    || txtClave.Text.Equals("") || txtConfirmarClave.Text.Equals("") ||
                    cboEstado.SelectedValue.ToString().Equals("-1") || cboPerfil.SelectedValue.ToString().Equals("-1"))
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
                    u.CodEstado = Convert.ToInt32(cboEstado.SelectedValue);
                    u.Correo = txtCorreo.Text.Trim();
                    if (Convert.ToInt32(cboPerfil.SelectedValue) == 1)
                    {
                        u.Rol = "Funcionario";
                    }
                    else 
                    {
                        u.Rol = "Estudiante";
                    }                   

                    // Se consume el metodo de registro
                    if (Logica.Ingresar_Mant_Usuario(u) > 0)
                    {
                        MessageBox.Show("Usuario Registrado con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIdentificacion.Text = "";
                        txtNombre.Text = "";
                        txtPrimerApellido.Text = "";
                        txtSegundoApellido.Text = "";
                        txtUsuario.Text = "";
                        txtClave.Text = "";
                        txtConfirmarClave.Text = "";
                        cboEstado.SelectedValue = "-1";
                        cboPerfil.SelectedValue = "-1";
                        txtCorreo.Text = "";
                        CargarListado();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (txtIdentificacion.Text.Equals("") || txtNombre.Text.Equals("")
                    || txtPrimerApellido.Text.Equals("") || txtSegundoApellido.Text.Equals("")
                    || txtUsuario.Text.Equals("")
                    || txtCorreo.Text.Equals("")
                    || txtClave.Text.Equals("") || txtConfirmarClave.Text.Equals("") ||
                    cboEstado.SelectedValue.ToString().Equals("-1") || cboPerfil.SelectedValue.ToString().Equals("-1"))
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
                    u.CodEstado = Convert.ToInt32(cboEstado.SelectedValue);
                    u.Correo = txtCorreo.Text.Trim();
                    if (Convert.ToInt32(cboPerfil.SelectedValue) == 1)
                    {
                        u.Rol = "Funcionario";
                    }
                    else
                    {
                        u.Rol = "Estudiante";
                    }

                    // Se consume el metodo de registro
                    if (Logica.Modificar_Mant_Usuario(u) > 0)
                    {
                        MessageBox.Show("Usuario Modificado con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIdentificacion.Text = "";
                        txtNombre.Text = "";
                        txtPrimerApellido.Text = "";
                        txtSegundoApellido.Text = "";
                        txtUsuario.Text = "";
                        txtClave.Text = "";
                        txtConfirmarClave.Text = "";
                        cboEstado.SelectedValue = "-1";
                        cboPerfil.SelectedValue = "-1";
                        txtCorreo.Text = "";
                        CargarListado();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible realizar la modificacion por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar la modificacion por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (txtIdentificacion.Text.Equals("") || txtIdentificacion.Text.Equals(" -    -"))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Debe de seleccionar un usuario a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Usuarios u = new Usuarios();
                    // Asignacion de los objetos
                    u.Identificacion = txtIdentificacion.Text.Trim();

                    // Se consume el metodo de registro
                    if (Logica.Eliminar_Mant_Usuario(u) > 0)
                    {
                        MessageBox.Show("Usuario Eliminado con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIdentificacion.Text = "";
                        txtNombre.Text = "";
                        txtPrimerApellido.Text = "";
                        txtSegundoApellido.Text = "";
                        txtUsuario.Text = "";
                        txtClave.Text = "";
                        txtConfirmarClave.Text = "";
                        cboEstado.SelectedValue = "-1";
                        cboPerfil.SelectedValue = "-1";
                        CargarListado();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible realizar el eliminar por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el eliminar por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dGridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string identificacion, nombre, primer_apellido, segundo_apellido, usuario, clave, rol, correo;
                int estado;

                int FilaActual;
                FilaActual = dGridUsuario.CurrentRow.Index;

                identificacion = dGridUsuario.Rows[FilaActual].Cells["Identificacion"].Value.ToString();
                txtIdentificacion.Text = identificacion;

                nombre = dGridUsuario.Rows[FilaActual].Cells["Nombre"].Value.ToString();
                txtNombre.Text = nombre;

                primer_apellido = dGridUsuario.Rows[FilaActual].Cells["Primer_Apellido"].Value.ToString();
                txtPrimerApellido.Text = primer_apellido;

                segundo_apellido = dGridUsuario.Rows[FilaActual].Cells["Segundo_Apellido"].Value.ToString();
                txtSegundoApellido.Text = segundo_apellido;

                usuario = dGridUsuario.Rows[FilaActual].Cells["Usuario"].Value.ToString();
                txtUsuario.Text = usuario;

                clave = dGridUsuario.Rows[FilaActual].Cells["Clave"].Value.ToString();
                txtClave.Text = clave;
                txtConfirmarClave.Text = clave;


                estado = (int)dGridUsuario.Rows[FilaActual].Cells[6].Value;

                if (estado == 1)
                {
                    cboEstado.SelectedValue = 1;
                }
                else
                {
                    cboEstado.SelectedValue = 2;
                }
                rol = dGridUsuario.Rows[FilaActual].Cells["Rol"].Value.ToString();
                if (rol == "Funcionario")
                {
                    cboPerfil.SelectedValue = 1;
                }
                else
                {
                    cboPerfil.SelectedValue = 2;
                }

                correo = dGridUsuario.Rows[FilaActual].Cells["Correo"].Value.ToString();
                txtCorreo.Text = correo;
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible realizar la carga de informacion por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
