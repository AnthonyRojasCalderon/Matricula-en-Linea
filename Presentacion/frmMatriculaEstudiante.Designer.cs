namespace Presentacion
{
    partial class frmMatriculaEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatriculaEstudiante));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrarAula = new System.Windows.Forms.Button();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.cboProfesor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCedulaSesion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSegundoApellido);
            this.groupBox1.Controls.Add(this.txtPrimerApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 487);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 197);
            this.dataGridView1.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.btnMatricular);
            this.groupBox4.Location = new System.Drawing.Point(15, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(824, 99);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Limpiar Formulario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(549, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 47);
            this.button4.TabIndex = 1;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(61, 30);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(217, 47);
            this.btnMatricular.TabIndex = 0;
            this.btnMatricular.Text = "Matricular ";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblProfesor);
            this.groupBox2.Controls.Add(this.cboProfesor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboCarrera);
            this.groupBox2.Controls.Add(this.lblMateria);
            this.groupBox2.Controls.Add(this.cboMateria);
            this.groupBox2.Location = new System.Drawing.Point(374, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 145);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnVolver);
            this.groupBox3.Controls.Add(this.btnRegistrarAula);
            this.groupBox3.Location = new System.Drawing.Point(0, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 99);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(289, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 47);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Aula";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(152, 32);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 47);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Aula";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(425, 32);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 47);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar Formulario";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(562, 32);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 47);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarAula
            // 
            this.btnRegistrarAula.Location = new System.Drawing.Point(15, 32);
            this.btnRegistrarAula.Name = "btnRegistrarAula";
            this.btnRegistrarAula.Size = new System.Drawing.Size(131, 47);
            this.btnRegistrarAula.TabIndex = 0;
            this.btnRegistrarAula.Text = "Registrar Aula";
            this.btnRegistrarAula.UseVisualStyleBackColor = true;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProfesor.Location = new System.Drawing.Point(19, 105);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(70, 18);
            this.lblProfesor.TabIndex = 23;
            this.lblProfesor.Text = "Profesor:";
            // 
            // cboProfesor
            // 
            this.cboProfesor.FormattingEnabled = true;
            this.cboProfesor.Location = new System.Drawing.Point(101, 102);
            this.cboProfesor.Name = "cboProfesor";
            this.cboProfesor.Size = new System.Drawing.Size(344, 21);
            this.cboProfesor.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(18, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Carrera:";
            // 
            // cboCarrera
            // 
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(100, 23);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(344, 21);
            this.cboCarrera.TabIndex = 20;
            this.cboCarrera.SelectedValueChanged += new System.EventHandler(this.cboCarrera_SelectedValueChanged);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMateria.Location = new System.Drawing.Point(19, 65);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(61, 18);
            this.lblMateria.TabIndex = 19;
            this.lblMateria.Text = "Materia:";
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(101, 62);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(344, 21);
            this.cboMateria.TabIndex = 0;
            this.cboMateria.SelectedValueChanged += new System.EventHandler(this.cboMateria_SelectedValueChanged);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Enabled = false;
            this.txtSegundoApellido.Location = new System.Drawing.Point(153, 135);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(215, 20);
            this.txtSegundoApellido.TabIndex = 17;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(153, 94);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(215, 20);
            this.txtPrimerApellido.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(153, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Segundo Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Primer Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Enabled = false;
            this.txtIdentificacion.Location = new System.Drawing.Point(153, 11);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(215, 20);
            this.txtIdentificacion.TabIndex = 11;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigo.Location = new System.Drawing.Point(12, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(97, 18);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Identificación:";
            // 
            // lblCedulaSesion
            // 
            this.lblCedulaSesion.AutoSize = true;
            this.lblCedulaSesion.Location = new System.Drawing.Point(816, 7);
            this.lblCedulaSesion.Name = "lblCedulaSesion";
            this.lblCedulaSesion.Size = new System.Drawing.Size(35, 13);
            this.lblCedulaSesion.TabIndex = 26;
            this.lblCedulaSesion.Text = "label1";
            this.lblCedulaSesion.Visible = false;
            // 
            // frmMatriculaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 509);
            this.Controls.Add(this.lblCedulaSesion);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMatriculaEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula en Línea";
            this.Load += new System.EventHandler(this.frmMatriculaEstudiante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ComboBox cboProfesor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarAula;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.Label lblCedulaSesion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}