namespace Presentacion
{
    partial class frmCambioContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioContrasena));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCedulaSesion = new System.Windows.Forms.Label();
            this.txtClaveConfirmar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveTemporal = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblClaveTemporal = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCedulaSesion);
            this.groupBox1.Controls.Add(this.txtClaveConfirmar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClaveTemporal);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.lblClaveTemporal);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.lblClave);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.imgLogo);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 444);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clave Temporal de Sistema";
            // 
            // lblCedulaSesion
            // 
            this.lblCedulaSesion.AutoSize = true;
            this.lblCedulaSesion.Location = new System.Drawing.Point(7, 429);
            this.lblCedulaSesion.Name = "lblCedulaSesion";
            this.lblCedulaSesion.Size = new System.Drawing.Size(35, 13);
            this.lblCedulaSesion.TabIndex = 12;
            this.lblCedulaSesion.Text = "label2";
            this.lblCedulaSesion.Visible = false;
            // 
            // txtClaveConfirmar
            // 
            this.txtClaveConfirmar.Location = new System.Drawing.Point(273, 313);
            this.txtClaveConfirmar.Name = "txtClaveConfirmar";
            this.txtClaveConfirmar.PasswordChar = '*';
            this.txtClaveConfirmar.Size = new System.Drawing.Size(215, 20);
            this.txtClaveConfirmar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(107, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirmar Contraseña:";
            // 
            // txtClaveTemporal
            // 
            this.txtClaveTemporal.Location = new System.Drawing.Point(273, 247);
            this.txtClaveTemporal.Name = "txtClaveTemporal";
            this.txtClaveTemporal.Size = new System.Drawing.Size(215, 20);
            this.txtClaveTemporal.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(110, 353);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(378, 23);
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // lblClaveTemporal
            // 
            this.lblClaveTemporal.AutoSize = true;
            this.lblClaveTemporal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveTemporal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClaveTemporal.Location = new System.Drawing.Point(150, 250);
            this.lblClaveTemporal.Name = "lblClaveTemporal";
            this.lblClaveTemporal.Size = new System.Drawing.Size(116, 18);
            this.lblClaveTemporal.TabIndex = 0;
            this.lblClaveTemporal.Text = "Clave Temporal:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(110, 395);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(175, 28);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Cambiar Contraseña";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(329, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 28);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Ingreso al Sistema";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClave.Location = new System.Drawing.Point(131, 282);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(135, 18);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Contraseña Nueva:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(273, 278);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(215, 22);
            this.txtClave.TabIndex = 2;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(6, 19);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(635, 204);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 5;
            this.imgLogo.TabStop = false;
            // 
            // frmCambioContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 463);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambioContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula en Línea";
            this.Load += new System.EventHandler(this.frmCambioContrasena_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClaveConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveTemporal;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblClaveTemporal;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblCedulaSesion;
    }
}