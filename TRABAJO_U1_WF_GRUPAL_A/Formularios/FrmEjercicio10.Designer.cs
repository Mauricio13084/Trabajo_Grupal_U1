namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    partial class FrmEjercicio10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjercicio10));
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.dgvPromedioEspecialidad = new System.Windows.Forms.DataGridView();
            this.colEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPromedioGeneral = new System.Windows.Forms.Label();
            this.lblMejorEspecialidad = new System.Windows.Forms.Label();
            this.lblTurnoNotasAltas = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvEvaluacion = new System.Windows.Forms.DataGridView();
            this.colTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPediatria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGinecologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInternista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeurologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedioEspecialidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpResultado
            // 
            this.grpResultado.BackColor = System.Drawing.Color.SeaShell;
            this.grpResultado.Controls.Add(this.dgvPromedioEspecialidad);
            this.grpResultado.Controls.Add(this.lblPromedioGeneral);
            this.grpResultado.Controls.Add(this.lblMejorEspecialidad);
            this.grpResultado.Controls.Add(this.lblTurnoNotasAltas);
            this.grpResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultado.Location = new System.Drawing.Point(43, 298);
            this.grpResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpResultado.Size = new System.Drawing.Size(850, 228);
            this.grpResultado.TabIndex = 7;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado";
            // 
            // dgvPromedioEspecialidad
            // 
            this.dgvPromedioEspecialidad.AllowUserToAddRows = false;
            this.dgvPromedioEspecialidad.AllowUserToDeleteRows = false;
            this.dgvPromedioEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromedioEspecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEspecialidad,
            this.colPromedio});
            this.dgvPromedioEspecialidad.Location = new System.Drawing.Point(448, 28);
            this.dgvPromedioEspecialidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPromedioEspecialidad.Name = "dgvPromedioEspecialidad";
            this.dgvPromedioEspecialidad.ReadOnly = true;
            this.dgvPromedioEspecialidad.RowHeadersVisible = false;
            this.dgvPromedioEspecialidad.RowHeadersWidth = 51;
            this.dgvPromedioEspecialidad.RowTemplate.Height = 24;
            this.dgvPromedioEspecialidad.Size = new System.Drawing.Size(365, 176);
            this.dgvPromedioEspecialidad.TabIndex = 3;
            // 
            // colEspecialidad
            // 
            this.colEspecialidad.HeaderText = "Especialidad";
            this.colEspecialidad.MinimumWidth = 6;
            this.colEspecialidad.Name = "colEspecialidad";
            this.colEspecialidad.ReadOnly = true;
            this.colEspecialidad.Width = 220;
            // 
            // colPromedio
            // 
            this.colPromedio.HeaderText = "Promedio";
            this.colPromedio.MinimumWidth = 6;
            this.colPromedio.Name = "colPromedio";
            this.colPromedio.ReadOnly = true;
            this.colPromedio.Width = 125;
            // 
            // lblPromedioGeneral
            // 
            this.lblPromedioGeneral.AutoSize = true;
            this.lblPromedioGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPromedioGeneral.Location = new System.Drawing.Point(20, 129);
            this.lblPromedioGeneral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedioGeneral.Name = "lblPromedioGeneral";
            this.lblPromedioGeneral.Size = new System.Drawing.Size(154, 20);
            this.lblPromedioGeneral.TabIndex = 2;
            this.lblPromedioGeneral.Text = "Promedio general:";
            // 
            // lblMejorEspecialidad
            // 
            this.lblMejorEspecialidad.AutoSize = true;
            this.lblMejorEspecialidad.Location = new System.Drawing.Point(20, 83);
            this.lblMejorEspecialidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMejorEspecialidad.Name = "lblMejorEspecialidad";
            this.lblMejorEspecialidad.Size = new System.Drawing.Size(212, 20);
            this.lblMejorEspecialidad.TabIndex = 1;
            this.lblMejorEspecialidad.Text = "Especialidad con mejor nota:";
            // 
            // lblTurnoNotasAltas
            // 
            this.lblTurnoNotasAltas.AutoSize = true;
            this.lblTurnoNotasAltas.Location = new System.Drawing.Point(20, 44);
            this.lblTurnoNotasAltas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurnoNotasAltas.Name = "lblTurnoNotasAltas";
            this.lblTurnoNotasAltas.Size = new System.Drawing.Size(296, 20);
            this.lblTurnoNotasAltas.TabIndex = 0;
            this.lblTurnoNotasAltas.Text = "Turno con todas las evaluaciones >= 4.0:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Location = new System.Drawing.Point(131, 251);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(148, 33);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvEvaluacion
            // 
            this.dgvEvaluacion.AllowUserToAddRows = false;
            this.dgvEvaluacion.AllowUserToDeleteRows = false;
            this.dgvEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTurno,
            this.colPediatria,
            this.colGinecologia,
            this.colInternista,
            this.colNeurologia});
            this.dgvEvaluacion.Location = new System.Drawing.Point(131, 98);
            this.dgvEvaluacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEvaluacion.Name = "dgvEvaluacion";
            this.dgvEvaluacion.ReadOnly = true;
            this.dgvEvaluacion.RowHeadersWidth = 51;
            this.dgvEvaluacion.RowTemplate.Height = 24;
            this.dgvEvaluacion.Size = new System.Drawing.Size(687, 139);
            this.dgvEvaluacion.TabIndex = 5;
            // 
            // colTurno
            // 
            this.colTurno.HeaderText = "Turno";
            this.colTurno.MinimumWidth = 6;
            this.colTurno.Name = "colTurno";
            this.colTurno.ReadOnly = true;
            this.colTurno.Width = 125;
            // 
            // colPediatria
            // 
            this.colPediatria.HeaderText = "Pediatria";
            this.colPediatria.MinimumWidth = 6;
            this.colPediatria.Name = "colPediatria";
            this.colPediatria.ReadOnly = true;
            this.colPediatria.Width = 125;
            // 
            // colGinecologia
            // 
            this.colGinecologia.HeaderText = "Ginecologia";
            this.colGinecologia.MinimumWidth = 6;
            this.colGinecologia.Name = "colGinecologia";
            this.colGinecologia.ReadOnly = true;
            this.colGinecologia.Width = 125;
            // 
            // colInternista
            // 
            this.colInternista.HeaderText = "Internista";
            this.colInternista.MinimumWidth = 6;
            this.colInternista.Name = "colInternista";
            this.colInternista.ReadOnly = true;
            this.colInternista.Width = 125;
            // 
            // colNeurologia
            // 
            this.colNeurologia.HeaderText = "Neurologia";
            this.colNeurologia.MinimumWidth = 6;
            this.colNeurologia.Name = "colNeurologia";
            this.colNeurologia.ReadOnly = true;
            this.colNeurologia.Width = 125;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.SteelBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(66, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 15);
            this.label13.TabIndex = 40;
            this.label13.Text = "PRIVADA DE TACNA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.SteelBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(66, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "UNIVERSIDAD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.SteelBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(296, 16);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(460, 31);
            this.label15.TabIndex = 37;
            this.label15.Text = "EVALUACION DE SERVICIO EPS";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.Location = new System.Drawing.Point(-2, -1);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(948, 63);
            this.textBox1.TabIndex = 36;
            // 
            // FrmEjercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvEvaluacion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEjercicio10";
            this.Text = "FrmEjercicio10";
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedioEspecialidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.DataGridView dgvPromedioEspecialidad;
        private System.Windows.Forms.Label lblPromedioGeneral;
        private System.Windows.Forms.Label lblMejorEspecialidad;
        private System.Windows.Forms.Label lblTurnoNotasAltas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPediatria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGinecologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInternista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNeurologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromedio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
    }
}