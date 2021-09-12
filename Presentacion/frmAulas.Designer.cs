namespace Presentacion
{
    partial class frmAulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAulas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCedulaSesion = new System.Windows.Forms.Label();
            this.dGridAulas = new System.Windows.Forms.DataGridView();
            this.txtCodigoAula = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrarAula = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcionAula = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAulas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblCedulaSesion);
            this.groupBox1.Controls.Add(this.dGridAulas);
            this.groupBox1.Controls.Add(this.txtCodigoAula);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtDescripcionAula);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 471);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de Aulas";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(305, 316);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(272, 21);
            this.cboEstado.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstado.Location = new System.Drawing.Point(161, 320);
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
            // dGridAulas
            // 
            this.dGridAulas.AllowUserToAddRows = false;
            this.dGridAulas.AllowUserToDeleteRows = false;
            this.dGridAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAulas.Location = new System.Drawing.Point(154, 19);
            this.dGridAulas.Name = "dGridAulas";
            this.dGridAulas.ReadOnly = true;
            this.dGridAulas.Size = new System.Drawing.Size(442, 172);
            this.dGridAulas.TabIndex = 22;
            this.dGridAulas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridAulas_CellContentClick);
            this.dGridAulas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridAulas_CellContentDoubleClick);
            this.dGridAulas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridAulas_CellDoubleClick);
            // 
            // txtCodigoAula
            // 
            this.txtCodigoAula.Location = new System.Drawing.Point(305, 226);
            this.txtCodigoAula.Name = "txtCodigoAula";
            this.txtCodigoAula.Size = new System.Drawing.Size(272, 20);
            this.txtCodigoAula.TabIndex = 1;
            this.txtCodigoAula.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.btnRegistrarAula);
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
            this.btnEliminar.Text = "Eliminar Aula";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(152, 32);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 47);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Aula";
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
            // btnRegistrarAula
            // 
            this.btnRegistrarAula.Location = new System.Drawing.Point(15, 32);
            this.btnRegistrarAula.Name = "btnRegistrarAula";
            this.btnRegistrarAula.Size = new System.Drawing.Size(131, 47);
            this.btnRegistrarAula.TabIndex = 0;
            this.btnRegistrarAula.Text = "Registrar Aula";
            this.btnRegistrarAula.UseVisualStyleBackColor = true;
            this.btnRegistrarAula.Click += new System.EventHandler(this.btnRegistrarAula_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigo.Location = new System.Drawing.Point(161, 228);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(92, 18);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código Aula:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(161, 274);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(123, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Descripción Aula:";
            // 
            // txtDescripcionAula
            // 
            this.txtDescripcionAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionAula.Location = new System.Drawing.Point(305, 270);
            this.txtDescripcionAula.Name = "txtDescripcionAula";
            this.txtDescripcionAula.Size = new System.Drawing.Size(272, 22);
            this.txtDescripcionAula.TabIndex = 2;
            // 
            // frmAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 496);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula en Línea";
            this.Load += new System.EventHandler(this.frmAulas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAulas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCedulaSesion;
        private System.Windows.Forms.DataGridView dGridAulas;
        private System.Windows.Forms.MaskedTextBox txtCodigoAula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarAula;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcionAula;
    }
}