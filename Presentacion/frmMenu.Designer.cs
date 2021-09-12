namespace Presentacion
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosPorPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNotaDebitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasPorEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasMatriculadasYCongeladasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_nomusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clavesTemporalesYActivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSistemaToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "&Sistema";
            // 
            // cerrarSistemaToolStripMenuItem
            // 
            this.cerrarSistemaToolStripMenuItem.Name = "cerrarSistemaToolStripMenuItem";
            this.cerrarSistemaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cerrarSistemaToolStripMenuItem.Text = "Cerrar sistema";
            this.cerrarSistemaToolStripMenuItem.Click += new System.EventHandler(this.cerrarSistemaToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.perfilesToolStripMenuItem,
            this.usuariosPorPerfilesToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.carrerasToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientoToolStripMenuItem.Text = "&Mantenimientos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.perfilesToolStripMenuItem.Text = "Profesores";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click);
            // 
            // usuariosPorPerfilesToolStripMenuItem
            // 
            this.usuariosPorPerfilesToolStripMenuItem.Name = "usuariosPorPerfilesToolStripMenuItem";
            this.usuariosPorPerfilesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.usuariosPorPerfilesToolStripMenuItem.Text = "Aulas";
            this.usuariosPorPerfilesToolStripMenuItem.Click += new System.EventHandler(this.usuariosPorPerfilesToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            this.carrerasToolStripMenuItem.Click += new System.EventHandler(this.carrerasToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registraVentaToolStripMenuItem,
            this.registrarNotaDebitoToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.procesosToolStripMenuItem.Text = "&Matricula";
            // 
            // registraVentaToolStripMenuItem
            // 
            this.registraVentaToolStripMenuItem.Name = "registraVentaToolStripMenuItem";
            this.registraVentaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registraVentaToolStripMenuItem.Text = "Registrar Matricula";
            this.registraVentaToolStripMenuItem.Click += new System.EventHandler(this.registraVentaToolStripMenuItem_Click);
            // 
            // registrarNotaDebitoToolStripMenuItem
            // 
            this.registrarNotaDebitoToolStripMenuItem.Name = "registrarNotaDebitoToolStripMenuItem";
            this.registrarNotaDebitoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registrarNotaDebitoToolStripMenuItem.Text = "Congelar Matricula";
            this.registrarNotaDebitoToolStripMenuItem.Click += new System.EventHandler(this.registrarNotaDebitoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeUsuariosToolStripMenuItem,
            this.listadoDeVentasToolStripMenuItem,
            this.aulasPorEstadoToolStripMenuItem,
            this.materiasMatriculadasYCongeladasToolStripMenuItem,
            this.clavesTemporalesYActivasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.consultasToolStripMenuItem.Text = "&Reportes";
            // 
            // listadoDeUsuariosToolStripMenuItem
            // 
            this.listadoDeUsuariosToolStripMenuItem.Name = "listadoDeUsuariosToolStripMenuItem";
            this.listadoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.listadoDeUsuariosToolStripMenuItem.Text = "Usuarios Activos e Inactivos";
            this.listadoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeUsuariosToolStripMenuItem_Click);
            // 
            // listadoDeVentasToolStripMenuItem
            // 
            this.listadoDeVentasToolStripMenuItem.Name = "listadoDeVentasToolStripMenuItem";
            this.listadoDeVentasToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.listadoDeVentasToolStripMenuItem.Text = "Profesores Activos e Inactivos";
            this.listadoDeVentasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeVentasToolStripMenuItem_Click);
            // 
            // aulasPorEstadoToolStripMenuItem
            // 
            this.aulasPorEstadoToolStripMenuItem.Name = "aulasPorEstadoToolStripMenuItem";
            this.aulasPorEstadoToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.aulasPorEstadoToolStripMenuItem.Text = "Aulas por Estado";
            this.aulasPorEstadoToolStripMenuItem.Click += new System.EventHandler(this.aulasPorEstadoToolStripMenuItem_Click);
            // 
            // materiasMatriculadasYCongeladasToolStripMenuItem
            // 
            this.materiasMatriculadasYCongeladasToolStripMenuItem.Name = "materiasMatriculadasYCongeladasToolStripMenuItem";
            this.materiasMatriculadasYCongeladasToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.materiasMatriculadasYCongeladasToolStripMenuItem.Text = "Materias Matriculadas y Congeladas";
            this.materiasMatriculadasYCongeladasToolStripMenuItem.Click += new System.EventHandler(this.materiasMatriculadasYCongeladasToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_nomusuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "Usuario conectado:";
            // 
            // tssl_nomusuario
            // 
            this.tssl_nomusuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tssl_nomusuario.Name = "tssl_nomusuario";
            this.tssl_nomusuario.Size = new System.Drawing.Size(55, 17);
            this.tssl_nomusuario.Text = "(usuario)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(543, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(71, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha y Hora";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.matricula_en_linea;
            this.pictureBox1.Location = new System.Drawing.Point(198, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // clavesTemporalesYActivasToolStripMenuItem
            // 
            this.clavesTemporalesYActivasToolStripMenuItem.Name = "clavesTemporalesYActivasToolStripMenuItem";
            this.clavesTemporalesYActivasToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.clavesTemporalesYActivasToolStripMenuItem.Text = "Claves Temporales y Activas";
            this.clavesTemporalesYActivasToolStripMenuItem.Click += new System.EventHandler(this.clavesTemporalesYActivasToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula en Línea";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosPorPerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNotaDebitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeVentasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_nomusuario;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulasPorEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasMatriculadasYCongeladasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clavesTemporalesYActivasToolStripMenuItem;
    }
}