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
    public partial class frmProfesores : Form
    {
        public string Usuario { get; set; }

        public frmProfesores()
        {
            InitializeComponent();
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            lblCedulaSesion.Text = Usuario;
            CargarListado();
            CargarEstado();
            CargarMaterias();
        }

        public List<Profesores> lstProfesores { get; set; }

        private void CargarListado()
        {
            try
            {
                lstProfesores = Logica.ConsultaProfesores();
                dGridProfesores.DataSource = lstProfesores;
                dGridProfesores.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        private void CargarMaterias()
        {
            List<Materias> lstcarreras = Logica.ConsultaMaterias();
            cboMateria.DataSource = lstcarreras;
            cboMateria.DisplayMember = "DescMateria";
            cboMateria.ValueMember = "CodigoMateria";
            cboMateria.Refresh();
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
                txtCodigoProfesor.Text = "";
                txtNombreProfesor.Text = "";
                txtPrimerApellido.Text = "";
                txtSegundoApellido.Text = "";
                cboMateria.SelectedValue = "-1";
                cboEstado.SelectedValue = "-1";
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (txtCodigoProfesor.Text.Equals("") || txtNombreProfesor.Text.Equals("")
                    || txtPrimerApellido.Text.Equals("") || txtSegundoApellido.Text.Equals("")
                    || cboEstado.SelectedValue.ToString().Equals("-1")
                    || cboMateria.SelectedValue.ToString().Equals("-1"))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Profesores u = new Profesores();
                    // Asignacion de los objetos
                    u.Identificacion = txtCodigoProfesor.Text.Trim();
                    u.Nombre = txtNombreProfesor.Text.Trim();
                    u.Primer_Apellido = txtPrimerApellido.Text.Trim();
                    u.Segundo_Apellido = txtSegundoApellido.Text.Trim();
                    u.CodMateria = Convert.ToInt32(cboMateria.SelectedValue);
                    u.CodEstado = Convert.ToInt32(cboEstado.SelectedValue);

                    // Se consume el metodo de registro
                    if (Logica.Ingresar_Mant_Profesores(u) > 0)
                    {
                        MessageBox.Show("Profesor Registrado con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoProfesor.Text = "";
                        txtNombreProfesor.Text = "";
                        txtPrimerApellido.Text = "";
                        txtSegundoApellido.Text = "";
                        cboEstado.SelectedValue = "-1";
                        cboMateria.SelectedValue = "-1";
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
                if (txtCodigoProfesor.Text.Equals("") || txtNombreProfesor.Text.Equals("")
                    || txtPrimerApellido.Text.Equals("") || txtSegundoApellido.Text.Equals("")
                    || cboEstado.SelectedValue.ToString().Equals("-1")
                    || cboMateria.SelectedValue.ToString().Equals("-1"))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Profesores u = new Profesores();
                    // Asignacion de los objetos
                    u.Identificacion = txtCodigoProfesor.Text.Trim();
                    u.Nombre = txtNombreProfesor.Text.Trim();
                    u.Primer_Apellido = txtPrimerApellido.Text.Trim();
                    u.Segundo_Apellido = txtSegundoApellido.Text.Trim();
                    u.CodMateria = Convert.ToInt32(cboMateria.SelectedValue);
                    u.CodEstado = Convert.ToInt32(cboEstado.SelectedValue);

                    // Se consume el metodo de registro
                    if (Logica.Modificar_Mant_Profesores(u) > 0)
                    {
                        MessageBox.Show("Profesor Modificado con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoProfesor.Text = "";
                        txtNombreProfesor.Text = "";
                        txtPrimerApellido.Text = "";
                        txtSegundoApellido.Text = "";
                        cboEstado.SelectedValue = "-1";
                        cboMateria.SelectedValue = "-1";
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
                if (txtCodigoProfesor.Text.Equals(""))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Debe de seleccionar un profesor a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Profesores a = new Profesores();
                    // Asignacion de los objetos
                    a.Identificacion = (txtCodigoProfesor.Text.Trim());

                    // Se consume el metodo de registro
                    if (Logica.Eliminar_Mant_Profesores(a) > 0)
                    {
                        MessageBox.Show("Profesor Eliminado con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoProfesor.Text = "";
                        txtNombreProfesor.Text = "";
                        txtPrimerApellido.Text = "";
                        txtSegundoApellido.Text = "";
                        cboEstado.SelectedValue = "-1";
                        cboMateria.SelectedValue = "-1";
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

        private void dGridProfesores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string identificacion,nombre, primer_apellido, segundo_apellido;
                int codigoMateria, codigoEstado;

                int FilaActual;
                FilaActual = dGridProfesores.CurrentRow.Index;

                identificacion = dGridProfesores.Rows[FilaActual].Cells[0].Value.ToString();
                txtCodigoProfesor.Text = identificacion.ToString();

                nombre = dGridProfesores.Rows[FilaActual].Cells[1].Value.ToString();
                txtNombreProfesor.Text = nombre;

                primer_apellido = dGridProfesores.Rows[FilaActual].Cells[2].Value.ToString();
                txtPrimerApellido.Text = primer_apellido;

                segundo_apellido = dGridProfesores.Rows[FilaActual].Cells[3].Value.ToString();
                txtSegundoApellido.Text = segundo_apellido;

                codigoMateria = (int)dGridProfesores.Rows[FilaActual].Cells[4].Value;
                cboMateria.SelectedValue = codigoMateria;

                codigoEstado = (int)dGridProfesores.Rows[FilaActual].Cells[6].Value;
                cboEstado.SelectedValue = codigoEstado;
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible realizar la carga de informacion por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
