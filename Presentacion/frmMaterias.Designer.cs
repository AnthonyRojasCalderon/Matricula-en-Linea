namespace Presentacion
{
    partial class frmMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCedulaSesion = new System.Windows.Forms.Label();
            this.dGridMaterias = new System.Windows.Forms.DataGridView();
            this.txtCodigoMateria = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrarMateria = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcionMateria = new System.Windows.Forms.TextBox();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridMaterias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCarrera);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblCedulaSesion);
            this.groupBox1.Controls.Add(this.dGridMaterias);
            this.groupBox1.Controls.Add(this.txtCodigoMateria);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtDescripcionMateria);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 471);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de Materias";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(305, 331);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(272, 21);
            this.cboEstado.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstado.Location = new System.Drawing.Point(161, 335);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(59, 18);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCedulaSesion
            // 
            this.lblCedulaSesion.AutoSize = true;
            this.lblCedulaSesion.Location = new System.Drawing.Point(9, 198);
            this.lblCedulaSesion.Name = "lblCedulaSesion";
            this.lblCedulaSesion.Size = new System.Drawing.Size(35, 13);
            this.lblCedulaSesion.TabIndex = 24;
            this.lblCedulaSesion.Text = "label1";
            this.lblCedulaSesion.Visible = false;
            // 
            // dGridMaterias
            // 
            this.dGridMaterias.AllowUserToAddRows = false;
            this.dGridMaterias.AllowUserToDeleteRows = false;
            this.dGridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridMaterias.Location = new System.Drawing.Point(27, 19);
            this.dGridMaterias.Name = "dGridMaterias";
            this.dGridMaterias.ReadOnly = true;
            this.dGridMaterias.Size = new System.Drawing.Size(678, 172);
            this.dGridMaterias.TabIndex = 22;
            this.dGridMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridMaterias_CellDoubleClick);
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(305, 206);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.Size = new System.Drawing.Size(272, 20);
            this.txtCodigoMateria.TabIndex = 1;
            this.txtCodigoMateria.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.btnRegistrarMateria);
            this.groupBox2.Location = new System.Drawing.Point(12, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 99);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(289, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 47);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Materia";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(152, 32);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 47);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Materia";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(425, 32);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 47);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar Formulario";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(562, 32);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 47);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarMateria
            // 
            this.btnRegistrarMateria.Location = new System.Drawing.Point(15, 32);
            this.btnRegistrarMateria.Name = "btnRegistrarMateria";
            this.btnRegistrarMateria.Size = new System.Drawing.Size(131, 47);
            this.btnRegistrarMateria.TabIndex = 0;
            this.btnRegistrarMateria.Text = "Registrar Materia";
            this.btnRegistrarMateria.UseVisualStyleBackColor = true;
            this.btnRegistrarMateria.Click += new System.EventHandler(this.btnRegistrarMateria_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigo.Location = new System.Drawing.Point(161, 208);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(113, 18);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código Materia:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(161, 254);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(119, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre Materia:";
            // 
            // txtDescripcionMateria
            // 
            this.txtDescripcionMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionMateria.Location = new System.Drawing.Point(305, 250);
            this.txtDescripcionMateria.Name = "txtDescripcionMateria";
            this.txtDescripcionMateria.Size = new System.Drawing.Size(272, 22);
            this.txtDescripcionMateria.TabIndex = 2;
            // 
            // cboCarrera
            // 
            this.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(305, 291);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(272, 21);
            this.cboCarrera.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(161, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Carrera:";
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 490);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula en Línea";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridMaterias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCedulaSesion;
        private System.Windows.Forms.DataGridView dGridMaterias;
        private System.Windows.Forms.MaskedTextBox txtCodigoMateria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarMateria;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcionMateria;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Label label1;
    }
}