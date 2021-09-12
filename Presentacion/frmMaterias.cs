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
    public partial class frmMaterias : Form
    {
        public string Usuario { get; set; }

        public frmMaterias()
        {
            InitializeComponent();
        }

        private void btnRegistrarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (txtCodigoMateria.Text.Equals("") || txtDescripcionMateria.Text.Equals("") ||
                    cboEstado.SelectedValue.ToString().Equals("-1") || cboCarrera.SelectedValue.ToString().Equals("-1"))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Materias a = new Materias();
                    // Asignacion de los objetos
                    a.CodigoMateria = Convert.ToInt32(txtCodigoMateria.Text.Trim());
                    a.DescMateria = txtDescripcionMateria.Text.Trim();
                    a.EstMateria = Convert.ToInt32(cboEstado.SelectedValue);
                    a.CodigoCarrera = Convert.ToInt32(cboCarrera.SelectedValue);

                    // Se consume el metodo de registro
                    if (Logica.Ingresar_Mant_Materias(a) > 0)
                    {
                        MessageBox.Show("Materia Registrada con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoMateria.Text = "";
                        txtDescripcionMateria.Text = "";
                        cboEstado.SelectedValue = "-1";
                        cboCarrera.SelectedValue = "-1";
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
                if (txtCodigoMateria.Text.Equals("") || txtDescripcionMateria.Text.Equals("") ||
                    cboEstado.SelectedValue.ToString().Equals("-1") || cboCarrera.SelectedValue.ToString().Equals("-1"))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Materias a = new Materias();
                    // Asignacion de los objetos
                    a.CodigoMateria = Convert.ToInt32(txtCodigoMateria.Text.Trim());
                    a.DescMateria = txtDescripcionMateria.Text.Trim();
                    a.EstMateria = Convert.ToInt32(cboEstado.SelectedValue);
                    a.CodigoCarrera = Convert.ToInt32(cboCarrera.SelectedValue);

                    // Se consume el metodo de registro
                    if (Logica.Modificar_Mant_Materias(a) > 0)
                    {
                        MessageBox.Show("Materia Modificada con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoMateria.Text = "";
                        txtDescripcionMateria.Text = "";
                        cboEstado.SelectedValue = "-1";
                        cboCarrera.SelectedValue = "-1";
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
                if (txtCodigoMateria.Text.Equals(""))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Debe de seleccionar una materia a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Materias a = new Materias();
                    // Asignacion de los objetos
                    a.CodigoMateria = Convert.ToInt32(txtCodigoMateria.Text.Trim());

                    // Se consume el metodo de registro
                    if (Logica.Eliminar_Mant_Materias(a) > 0)
                    {
                        MessageBox.Show("Materia Eliminada con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoMateria.Text = "";
                        txtDescripcionMateria.Text = "";
                        cboEstado.SelectedValue = "-1";
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigoMateria.Text = "";
                txtDescripcionMateria.Text = "";
                cboCarrera.SelectedValue = "-1";
                cboEstado.SelectedValue = "-1";
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public List<Materias> lstMaterias { get; set; }

        private void CargarListado()
        {
            try
            {
                lstMaterias = Logica.ConsultaMaterias();
                dGridMaterias.DataSource = lstMaterias;
                dGridMaterias.Refresh();
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

        private void CargarCarreras()
        {
            List<Carreras> lstcarreras = Logica.ConsultaCarreras();
            cboCarrera.DataSource = lstcarreras;
            cboCarrera.DisplayMember = "DescCarrera";
            cboCarrera.ValueMember = "CodigoCarrera";
            cboCarrera.Refresh();
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            lblCedulaSesion.Text = Usuario;
            CargarListado();
            CargarEstado();
            CargarCarreras();
        }

        private void dGridMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string descripcion;
                int codigoMateria, EstMateria, codigoCarrera;

                int FilaActual;
                FilaActual = dGridMaterias.CurrentRow.Index;

                codigoMateria = (int)dGridMaterias.Rows[FilaActual].Cells[0].Value;
                txtCodigoMateria.Text = codigoMateria.ToString(); 

                descripcion = dGridMaterias.Rows[FilaActual].Cells[1].Value.ToString();
                txtDescripcionMateria.Text = descripcion;

                EstMateria = (int)dGridMaterias.Rows[FilaActual].Cells[2].Value;
                cboEstado.SelectedValue = EstMateria;

                codigoCarrera = (int)dGridMaterias.Rows[FilaActual].Cells[3].Value;
                cboCarrera.SelectedValue = codigoCarrera;
            }

            catch (Exception)
            {
                MessageBox.Show("No fue posible realizar la carga de informacion por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
