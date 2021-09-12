namespace Presentacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContrasena = new System.Windows.Forms.LinkLabel();
            this.txtUsuario = new System.Windows.Forms.MaskedTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdentificacion.Location = new System.Drawing.Point(177, 286);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(97, 18);
            this.lblIdentificacion.TabIndex = 0;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClave.Location = new System.Drawing.Point(177, 325);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(89, 18);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Contraseña:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(280, 321);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(208, 22);
            this.txtClave.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(180, 410);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(132, 28);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContrasena);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.lblIdentificacion);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.btnRegistro);
            this.groupBox1.Controls.Add(this.lblClave);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.imgLogo);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 444);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso al Sistema";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblContrasena.Location = new System.Drawing.Point(177, 360);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(170, 18);
            this.lblContrasena.TabIndex = 8;
            this.lblContrasena.TabStop = true;
            this.lblContrasena.Text = "¿ Olvidó la Contraseña ?";
            this.lblContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblContrasena_LinkClicked);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(280, 284);
            this.txtUsuario.Mask = "#-####-####";
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(208, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(180, 381);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(308, 23);
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(356, 410);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(132, 28);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(6, 19);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(635, 244);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 5;
            this.imgLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(671, 463);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula en Línea";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MaskedTextBox txtUsuario;
        private System.Windows.Forms.LinkLabel lblContrasena;
    }
}

