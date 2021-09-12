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
    public partial class frmAulas : Form
    {
        public string Usuario { get; set; }

        public frmAulas()
        {
            InitializeComponent();
        }

        private void frmAulas_Load(object sender, EventArgs e)
        {
            lblCedulaSesion.Text = Usuario;
            CargarListado();
            CargarEstado();
        }

        public List<Aulas> lstAulas { get; set; }

        private void CargarListado()
        {
            try
            {
                lstAulas = Logica.ConsultaAulas();
                dGridAulas.DataSource = lstAulas;
                dGridAulas.Refresh();
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
            dt.Rows.Add("1", "Perfecto Estado");
            dt.Rows.Add("2", "Estado Medio");
            dt.Rows.Add("3", "Deteriorada");

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
                txtCodigoAula.Text = "";
                txtDescripcionAula.Text = "";
                cboEstado.SelectedValue = "-1";
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarAula_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (txtCodigoAula.Text.Equals("") || txtDescripcionAula.Text.Equals("") ||
                    cboEstado.SelectedValue.ToString().Equals("-1") )
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Aulas a = new Aulas();
                    // Asignacion de los objetos
                    a.CodigoAula = Convert.ToInt32(txtCodigoAula.Text.Trim());
                    a.DescAulas = txtDescripcionAula.Text.Trim();
                    a.EstAula = Convert.ToInt32(cboEstado.SelectedValue);

                    // Se consume el metodo de registro
                    if (Logica.Ingresar_Mant_Aulas(a) > 0)
                    {
                        MessageBox.Show("Aula Registrada con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoAula.Text = "";
                        txtDescripcionAula.Text = "";
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (txtCodigoAula.Text.Equals(""))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Debe de seleccionar un usuario a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Aulas a = new Aulas();
                    // Asignacion de los objetos
                    a.CodigoAula = Convert.ToInt32(txtCodigoAula.Text.Trim());

                    // Se consume el metodo de registro
                    if (Logica.Eliminar_Mant_Aulas(a) > 0)
                    {
                        MessageBox.Show("Aula Eliminada con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoAula.Text = "";
                        txtDescripcionAula.Text = "";
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
                if (txtCodigoAula.Text.Equals("") || txtDescripcionAula.Text.Equals("") ||
                    cboEstado.SelectedValue.ToString().Equals("-1"))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Aulas a = new Aulas();
                    // Asignacion de los objetos
                    a.CodigoAula = Convert.ToInt32(txtCodigoAula.Text.Trim());
                    a.DescAulas = txtDescripcionAula.Text;
                    a.EstAula= Convert.ToInt32(cboEstado.SelectedValue);

                    // Se consume el metodo de registro
                    if (Logica.Modificar_Mant_Aulas(a) > 0)
                    {
                        MessageBox.Show("Aula Modificada con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoAula.Text = "";
                        txtDescripcionAula.Text = "";
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

        private void dGridAulas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGridAulas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string descripcion;
                int codigoAula, EstAula;

                int FilaActual;
                FilaActual = dGridAulas.CurrentRow.Index;

                codigoAula = (int)dGridAulas.Rows[FilaActual].Cells[0].Value;
                txtCodigoAula.Text = codigoAula.ToString(); ;

                descripcion = dGridAulas.Rows[FilaActual].Cells[1].Value.ToString();
                txtDescripcionAula.Text = descripcion;

                EstAula = (int)dGridAulas.Rows[FilaActual].Cells[2].Value;
                cboEstado.SelectedValue = EstAula;
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible realizar la carga de informacion por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dGridAulas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
