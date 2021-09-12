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
    public partial class frmMatriculaEstudiante : Form
    {
        public string Usuario { get; set; }

        public frmMatriculaEstudiante()
        {
            InitializeComponent();
        }

        private void frmMatriculaEstudiante_Load(object sender, EventArgs e)
        {
            lblCedulaSesion.Text = Usuario;
            CargarInformacion(lblCedulaSesion.Text);
            CargarCarreras();
            CargarListado();
        }

        private void CargarCarreras()
        {
            try
            {
                List<Carreras> lstcarreras = Logica.ConsultaCarreras();
                cboCarrera.DataSource = lstcarreras;
                cboCarrera.DisplayMember = "DescCarrera";
                cboCarrera.ValueMember = "CodigoCarrera";
                cboCarrera.Refresh();
                CargarMaterias(Convert.ToInt32(cboCarrera.SelectedValue));
                CargarProfesores(Convert.ToInt32(cboMateria.SelectedValue));
            } catch (Exception) 
            { 
            }
        }

        private void CargarMaterias(int parametro)
        {
            try
            {
                List<Materias> lstcarreras = Logica.ConsultaMaterias_x_Carrera(parametro);
                cboMateria.DataSource = lstcarreras;
                cboMateria.DisplayMember = "DescMateria";
                cboMateria.ValueMember = "CodigoMateria";
                cboMateria.Refresh();
                lblMateria.Visible = true;
                cboMateria.Visible = true;
                CargarProfesores(Convert.ToInt32(cboMateria.SelectedValue));
            }
            catch (Exception) 
            { 
            }
        }

        private void CargarProfesores(int parametro)
        {
            try
            {
                List<Profesores> lstcarreras = Logica.ConsultaPofesores_x_Materia(parametro);
                cboProfesor.DataSource = lstcarreras;
                cboProfesor.DisplayMember = "Nombre";
                cboProfesor.ValueMember = "CodProfesor";
                cboProfesor.Refresh();
            }
            catch (Exception)
            { }
        }

        private void CargarInformacion(string param)
        {
            try
            {
                DataTable lstcarreras = Logica.ConsultaInformacion(param);
                txtIdentificacion.Text = lstcarreras.Rows[0]["Identificacion"].ToString();
                txtNombre.Text = lstcarreras.Rows[0]["Nombre"].ToString();
                txtPrimerApellido.Text = lstcarreras.Rows[0]["Primer_Apellido"].ToString();
                txtSegundoApellido.Text = lstcarreras.Rows[0]["Segundo_Apellido"].ToString();
            }
            catch (Exception)
            { 
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cboMateria.SelectedValue = "-1";
                cboMateria.SelectedValue = "-1";
                cboProfesor.SelectedValue = "-1";
            }
            catch (Exception)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el movimiento favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCarrera_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int valor;
                valor = Convert.ToInt32(cboCarrera.SelectedValue);
                if (valor > 0)
                {
                    CargarMaterias(valor);
                    //CargarProfesores(Convert.ToInt32(cboMateria.SelectedValue));
                }
            }
            catch (Exception)
            {
            }
        }

        private void cboMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int valor;
                valor = Convert.ToInt32(cboMateria.SelectedValue);
                if (valor > 0)
                {
                    //CargarMaterias(Convert.ToInt32(cboCarrera.SelectedValue));
                    CargarProfesores(valor);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                // se valida que los campos no estén vacios
                if (cboCarrera.SelectedValue.ToString().Equals("-1") 
                    || cboCarrera.SelectedValue.ToString().Equals("")
                    || cboMateria.SelectedValue.ToString().Equals("-1")
                    || cboMateria.SelectedValue.ToString().Equals("")
                    || cboProfesor.SelectedValue.ToString().Equals("-1")
                    || cboProfesor.SelectedValue.ToString().Equals(""))
                {
                    // se informa al usuario si existe un campo vacio
                    MessageBox.Show("Por favor complete la información solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Matricula a = new Matricula();
                    // Asignacion de los objetos
                    a.Identificacion = (txtIdentificacion.Text.Trim());
                    a.CodCarrera = Convert.ToInt32(cboCarrera.SelectedValue);
                    a.CodMateria = Convert.ToInt32(cboMateria.SelectedValue);
                    a.CodProfesor = Convert.ToInt32(cboProfesor.SelectedValue);

                    // Se consume el metodo de registro
                    if (Logica.Ingresar_Matricula(a) > 0)
                    {
                        MessageBox.Show("Matrícula Registrada con Éxito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CargarListado();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible realizar el registro por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // en caso de error se muestra un mensaje informativo
                MessageBox.Show("No fue posible realizar el registro por favor intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Matricula> lsMatricula { get; set; }

        private void CargarListado()
        {
            try
            {
                string ced = txtIdentificacion.Text.Trim();
                lsMatricula = Logica.ConsultaMatricula(ced);
                dataGridView1.DataSource = lsMatricula;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
