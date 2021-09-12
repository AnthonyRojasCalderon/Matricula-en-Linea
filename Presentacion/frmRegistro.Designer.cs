namespace Presentacion
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoPerfil = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.txtCodigoPerfil);
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
            this.groupBox1.Size = new System.Drawing.Size(647, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Usuarios";
            // 
            // txtCodigoPerfil
            // 
            this.txtCodigoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPerfil.Location = new System.Drawing.Point(138, 353);
            this.txtCodigoPerfil.Name = "txtCodigoPerfil";
            this.txtCodigoPerfil.ReadOnly = true;
            this.txtCodigoPerfil.Size = new System.Drawing.Size(272, 22);
            this.txtCodigoPerfil.TabIndex = 21;
            this.txtCodigoPerfil.Text = "Estudiante";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRol.Location = new System.Drawing.Point(6, 357);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(110, 18);
            this.lblRol.TabIndex = 20;
            this.lblRol.Text = "Perfil Asignado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.btnRegistrarUsuario);
            this.groupBox2.Location = new System.Drawing.Point(428, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 329);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(35, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 47);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar Formulario";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(35, 252);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 47);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(35, 66);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(131, 47);
            this.btnRegistrarUsuario.TabIndex = 0;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarClave.Location = new System.Drawing.Point(138, 310);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(272, 22);
            this.txtConfirmarClave.TabIndex = 8;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(138, 269);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(272, 22);
            this.txtClave.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(138, 223);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(272, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarClave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfirmarClave.Location = new System.Drawing.Point(6, 314);
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
            this.lblClave.Location = new System.Drawing.Point(6, 273);
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
            this.lblUsuario.Location = new System.Drawing.Point(6, 227);
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
            this.lblIdentificacion.Location = new System.Drawing.Point(6, 50);
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
            this.lblSegundoApellido.Location = new System.Drawing.Point(6, 188);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(126, 18);
            this.lblSegundoApellido.TabIndex = 7;
            this.lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(138, 184);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(272, 22);
            this.txtSegundoApellido.TabIndex = 4;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrimerApellido.Location = new System.Drawing.Point(6, 141);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(111, 18);
            this.lblPrimerApellido.TabIndex = 5;
            this.lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(138, 137);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(272, 22);
            this.txtPrimerApellido.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(6, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(138, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(6, 408);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(435, 13);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "Estimado funcionario: Para tramitar su usuario comunicarse al Departamento de Inf" +
    "ormática";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(138, 48);
            this.txtIdentificacion.Mask = "#-####-####";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(272, 20);
            this.txtIdentificacion.TabIndex = 1;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 448);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula en Línea";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblIdentificacion;
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
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtCodigoPerfil;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.MaskedTextBox txtIdentificacion;
    }
}