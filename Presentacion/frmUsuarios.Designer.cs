namespace Presentacion
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCedulaSesion = new System.Windows.Forms.Label();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.txtIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dGridUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblCedulaSesion);
            this.groupBox1.Controls.Add(this.cboPerfil);
            this.groupBox1.Controls.Add(this.dGridUsuario);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtConfirmarClave);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lblConfirmarClave);
            this.groupBox1.Controls.Add(this.lblClave);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblIdentificacion);
            this.groupBox1.Controls.Add(this.lblSegundoApellido);
            this.groupBox1.Controls.Add(this.txtSegundoApellido);
            this.groupBox1.Controls.Add(this.lblPrimerApellido);
            this.groupBox1.Controls.Add(this.txtPrimerApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 518);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de Usuarios";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(571, 387);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(272, 21);
            this.cboEstado.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstado.Location = new System.Drawing.Point(439, 391);
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
            // cboPerfil
            // 
            this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(571, 341);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(272, 21);
            this.cboPerfil.TabIndex = 10;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(141, 209);
            this.txtIdentificacion.Mask = "#-####-####";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(272, 20);
            this.txtIdentificacion.TabIndex = 1;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRol.Location = new System.Drawing.Point(439, 345);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(110, 18);
            this.lblRol.TabIndex = 20;
            this.lblRol.Text = "Perfil Asignado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.btnRegistrarUsuario);
            this.groupBox2.Location = new System.Drawing.Point(9, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 99);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(348, 30);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 47);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(211, 30);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 47);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar Usuario";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(484, 30);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 47);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Formulario";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(621, 30);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 47);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(74, 30);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(131, 47);
            this.btnRegistrarUsuario.TabIndex = 12;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarClave.Location = new System.Drawing.Point(571, 252);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(272, 22);
            this.txtConfirmarClave.TabIndex = 8;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(571, 207);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(272, 22);
            this.txtClave.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(141, 388);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(272, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarClave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfirmarClave.Location = new System.Drawing.Point(439, 256);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(119, 18);
            this.lblConfirmarClave.TabIndex = 15;
            this.lblConfirmarClave.Text = "Confirmar Clave:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClave.Location = new System.Drawing.Point(439, 211);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(49, 18);
            this.lblClave.TabIndex = 14;
            this.lblClave.Text = "Clave:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(9, 392);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdentificacion.Location = new System.Drawing.Point(9, 211);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(97, 18);
            this.lblIdentificacion.TabIndex = 9;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSegundoApellido.Location = new System.Drawing.Point(9, 349);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(126, 18);
            this.lblSegundoApellido.TabIndex = 7;
            this.lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(141, 345);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(272, 22);
            this.txtSegundoApellido.TabIndex = 4;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrimerApellido.Location = new System.Drawing.Point(9, 302);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(111, 18);
            this.lblPrimerApellido.TabIndex = 5;
            this.lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(141, 298);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(272, 22);
            this.txtPrimerApellido.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(9, 257);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(141, 253);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCorreo.Location = new System.Drawing.Point(439, 302);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(59, 18);
            this.lblCorreo.TabIndex = 27;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(571, 298);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(272, 22);
            this.txtCorreo.TabIndex = 9;
            // 
            // dGridUsuario
            // 
            this.dGridUsuario.AllowUserToAddRows = false;
            this.dGridUsuario.AllowUserToDeleteRows = false;
            this.dGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridUsuario.Location = new System.Drawing.Point(25, 19);
            this.dGridUsuario.Name = "dGridUsuario";
            this.dGridUsuario.ReadOnly = true;
            this.dGridUsuario.Size = new System.Drawing.Size(801, 172);
            this.dGridUsuario.TabIndex = 22;
            this.dGridUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridUsuario_CellDoubleClick);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 542);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula en Línea";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtIdentificacion;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblConfirmarClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Label lblCedulaSesion;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.DataGridView dGridUsuario;
    }
}