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
            this.label1 = new System.Windows.Forms.Label();
            this.grpResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedioEspecialidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacion)).BeginInit();
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
            this.grpResultado.Location = new System.Drawing.Point(62, 316);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(1133, 281);
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
            this.dgvPromedioEspecialidad.Location = new System.Drawing.Point(598, 34);
            this.dgvPromedioEspecialidad.Name = "dgvPromedioEspecialidad";
            this.dgvPromedioEspecialidad.ReadOnly = true;
            this.dgvPromedioEspecialidad.RowHeadersVisible = false;
            this.dgvPromedioEspecialidad.RowHeadersWidth = 51;
            this.dgvPromedioEspecialidad.RowTemplate.Height = 24;
            this.dgvPromedioEspecialidad.Size = new System.Drawing.Size(487, 216);
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
            this.lblPromedioGeneral.Location = new System.Drawing.Point(27, 159);
            this.lblPromedioGeneral.Name = "lblPromedioGeneral";
            this.lblPromedioGeneral.Size = new System.Drawing.Size(188, 25);
            this.lblPromedioGeneral.TabIndex = 2;
            this.lblPromedioGeneral.Text = "Promedio general:";
            // 
            // lblMejorEspecialidad
            // 
            this.lblMejorEspecialidad.AutoSize = true;
            this.lblMejorEspecialidad.Location = new System.Drawing.Point(27, 102);
            this.lblMejorEspecialidad.Name = "lblMejorEspecialidad";
            this.lblMejorEspecialidad.Size = new System.Drawing.Size(262, 25);
            this.lblMejorEspecialidad.TabIndex = 1;
            this.lblMejorEspecialidad.Text = "Especialidad con mejor nota:";
            // 
            // lblTurnoNotasAltas
            // 
            this.lblTurnoNotasAltas.AutoSize = true;
            this.lblTurnoNotasAltas.Location = new System.Drawing.Point(27, 54);
            this.lblTurnoNotasAltas.Name = "lblTurnoNotasAltas";
            this.lblTurnoNotasAltas.Size = new System.Drawing.Size(371, 25);
            this.lblTurnoNotasAltas.TabIndex = 0;
            this.lblTurnoNotasAltas.Text = "Turno con todas las evaluaciones >= 4.0:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Location = new System.Drawing.Point(179, 259);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(198, 41);
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
            this.dgvEvaluacion.Location = new System.Drawing.Point(179, 70);
            this.dgvEvaluacion.Name = "dgvEvaluacion";
            this.dgvEvaluacion.ReadOnly = true;
            this.dgvEvaluacion.RowHeadersWidth = 51;
            this.dgvEvaluacion.RowTemplate.Height = 24;
            this.dgvEvaluacion.Size = new System.Drawing.Size(916, 171);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(453, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evaluacion de Servicio EPS";
            // 
            // FrmEjercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 633);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvEvaluacion);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio10";
            this.Text = "FrmEjercicio10";
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedioEspecialidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacion)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromedio;
    }
}