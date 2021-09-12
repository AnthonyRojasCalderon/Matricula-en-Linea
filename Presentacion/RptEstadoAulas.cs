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
    public partial class RptEstadoAulas : Form
    {
        public string Usuario { get; set; }

        public RptEstadoAulas()
        {
            InitializeComponent();
        }

        private void RptEstadoAulas_Load(object sender, EventArgs e)
        {
            lblCedulaSesion.Text = Usuario;
            CargarAulas();
        }

        public List<RPTAulas> lstAulas { get; set; }

        private void CargarAulas()
        {
            try
            {
                lstAulas = Logica.ConsultaAulasEstados();
                dGridActivos.DataSource = lstAulas;
                dGridActivos.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
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
    }
}
