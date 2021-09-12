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
    public partial class frmCarreras : Form
    {
        public string Usuario { get; set; }

        public frmCarreras()
        {
            InitializeComponent();
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            lblCedulaSesion.Text = Usuario;
            CargarListado();
            CargarEstado();
        }

        public List<Carreras> lstCarreras { get; set; }
        
        private void CargarListado()
        {
            try
            {
                lstCarreras = Logica.ConsultaCarreras();
                dGridCarreras.DataSource = lstCarreras;
                dGridCarreras.Refresh();
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
                txtCodigoCarrera.Text = "";
                txtDescripcionCarrera.Text = "";
                cboEstado.SelectedValue = "-1";
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (txtCodigoCarrera.Text.Equals(""))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Debe de seleccionar un usuario a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Carreras a = new Carreras();
                    // Asignacion de los objetos
                    a.CodigoCarrera = Convert.ToInt32(txtCodigoCarrera.Text.Trim());

                    // Se consume el metodo de registro
                    if (Logica.Eliminar_Mant_Carreras(a) > 0)
                    {
                        MessageBox.Show("Carrera Eliminada con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoCarrera.Text = "";
                        txtDescripcionCarrera.Text = "";
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (txtCodigoCarrera.Text.Equals("") || txtDescripcionCarrera.Text.Equals("") ||
                    cboEstado.SelectedValue.ToString().Equals("-1"))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Carreras a = new Carreras();
                    // Asignacion de los objetos
                    a.CodigoCarrera = Convert.ToInt32(txtCodigoCarrera.Text.Trim());
                    a.DescCarrera = txtDescripcionCarrera.Text;
                    a.EstCarrera = Convert.ToInt32(cboEstado.SelectedValue);

                    // Se consume el metodo de registro
                    if (Logica.Modificar_Mant_Carreras(a) > 0)
                    {
                        MessageBox.Show("Carrera Modificada con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoCarrera.Text = "";
                        txtDescripcionCarrera.Text = "";
                        cboEstado.SelectedValue = "-1";
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

        private void btnRegistrarCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (txtCodigoCarrera.Text.Equals("") || txtDescripcionCarrera.Text.Equals("") ||
                    cboEstado.SelectedValue.ToString().Equals("-1"))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Carreras a = new Carreras();
                    // Asignacion de los objetos
                    a.CodigoCarrera = Convert.ToInt32(txtCodigoCarrera.Text.Trim());
                    a.DescCarrera = txtDescripcionCarrera.Text.Trim();
                    a.EstCarrera = Convert.ToInt32(cboEstado.SelectedValue);

                    // Se consume el metodo de registro
                    if (Logica.Ingresar_Mant_Carreras(a) > 0)
                    {
                        MessageBox.Show("Aula Registrada con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoCarrera.Text = "";
                        txtDescripcionCarrera.Text = "";
                        cboEstado.SelectedValue = "-1";
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

        private void dGridCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string descripcion;
                int codigoCarrera, EstCarrera;

                int FilaActual;
                FilaActual = dGridCarreras.CurrentRow.Index;

                codigoCarrera = (int)dGridCarreras.Rows[FilaActual].Cells[0].Value;
                txtCodigoCarrera.Text = codigoCarrera.ToString(); ;

                descripcion = dGridCarreras.Rows[FilaActual].Cells[1].Value.ToString();
                txtDescripcionCarrera.Text = descripcion;

                EstCarrera = (int)dGridCarreras.Rows[FilaActual].Cells[2].Value;
                cboEstado.SelectedValue = EstCarrera;
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible realizar la carga de informacion por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
