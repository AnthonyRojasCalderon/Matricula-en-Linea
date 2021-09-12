namespace Presentacion
{
    partial class RptUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptUsuarios));
            this.lblCedulaSesion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGridActivos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGridInactivos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridActivos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridInactivos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCedulaSesion
            // 
            this.lblCedulaSesion.AutoSize = true;
            this.lblCedulaSesion.Location = new System.Drawing.Point(554, 31);
            this.lblCedulaSesion.Name = "lblCedulaSesion";
            this.lblCedulaSesion.Size = new System.Drawing.Size(35, 13);
            this.lblCedulaSesion.TabIndex = 25;
            this.lblCedulaSesion.Text = "label1";
            this.lblCedulaSesion.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGridActivos);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 192);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios Activos";
            // 
            // dGridActivos
            // 
            this.dGridActivos.AllowUserToAddRows = false;
            this.dGridActivos.AllowUserToDeleteRows = false;
            this.dGridActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridActivos.Location = new System.Drawing.Point(11, 14);
            this.dGridActivos.Name = "dGridActivos";
            this.dGridActivos.ReadOnly = true;
            this.dGridActivos.Size = new System.Drawing.Size(758, 172);
            this.dGridActivos.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGridInactivos);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 205);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios Inactivos";
            // 
            // dGridInactivos
            // 
            this.dGridInactivos.AllowUserToAddRows = false;
            this.dGridInactivos.AllowUserToDeleteRows = false;
            this.dGridInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridInactivos.Location = new System.Drawing.Point(6, 19);
            this.dGridInactivos.Name = "dGridInactivos";
            this.dGridInactivos.ReadOnly = true;
            this.dGridInactivos.Size = new System.Drawing.Size(764, 180);
            this.dGridInactivos.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVolver);
            this.groupBox3.Controls.Add(this.lblCedulaSesion);
            this.groupBox3.Location = new System.Drawing.Point(12, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 71);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(320, 14);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 47);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // RptUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RptUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula en Línea";
            this.Load += new System.EventHandler(this.RptUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridActivos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridInactivos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCedulaSesion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dGridActivos;
        private System.Windows.Forms.DataGridView dGridInactivos;
    }
}