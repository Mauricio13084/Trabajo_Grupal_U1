namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    partial class FrmEjercicio9
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
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.colEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPractica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrabajos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnExamen = new System.Windows.Forms.TextBox();
            this.btnTrabajos = new System.Windows.Forms.TextBox();
            this.btnPractica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEvaluaciones
            // 
            this.dgvEvaluaciones.AllowUserToAddRows = false;
            this.dgvEvaluaciones.AllowUserToDeleteRows = false;
            this.dgvEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEstudiante,
            this.colPractica,
            this.colTrabajos,
            this.colExamen,
            this.colNotaFinal,
            this.colEstado});
            this.dgvEvaluaciones.Location = new System.Drawing.Point(103, 263);
            this.dgvEvaluaciones.Name = "dgvEvaluaciones";
            this.dgvEvaluaciones.ReadOnly = true;
            this.dgvEvaluaciones.RowHeadersWidth = 51;
            this.dgvEvaluaciones.RowTemplate.Height = 24;
            this.dgvEvaluaciones.Size = new System.Drawing.Size(1087, 226);
            this.dgvEvaluaciones.TabIndex = 5;
            // 
            // colEstudiante
            // 
            this.colEstudiante.HeaderText = "Estudiante";
            this.colEstudiante.MinimumWidth = 6;
            this.colEstudiante.Name = "colEstudiante";
            this.colEstudiante.ReadOnly = true;
            this.colEstudiante.Width = 125;
            // 
            // colPractica
            // 
            this.colPractica.HeaderText = "Practica";
            this.colPractica.MinimumWidth = 6;
            this.colPractica.Name = "colPractica";
            this.colPractica.ReadOnly = true;
            this.colPractica.Width = 125;
            // 
            // colTrabajos
            // 
            this.colTrabajos.HeaderText = "Trabajos";
            this.colTrabajos.MinimumWidth = 6;
            this.colTrabajos.Name = "colTrabajos";
            this.colTrabajos.ReadOnly = true;
            this.colTrabajos.Width = 125;
            // 
            // colExamen
            // 
            this.colExamen.HeaderText = "Examen";
            this.colExamen.MinimumWidth = 6;
            this.colExamen.Name = "colExamen";
            this.colExamen.ReadOnly = true;
            this.colExamen.Width = 125;
            // 
            // colNotaFinal
            // 
            this.colNotaFinal.HeaderText = "Nota Final";
            this.colNotaFinal.MinimumWidth = 6;
            this.colNotaFinal.Name = "colNotaFinal";
            this.colNotaFinal.ReadOnly = true;
            this.colNotaFinal.Width = 125;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.btnExamen);
            this.groupBox1.Controls.Add(this.btnTrabajos);
            this.groupBox1.Controls.Add(this.btnPractica);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(179, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(737, 105);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(193, 35);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnExamen
            // 
            this.btnExamen.Location = new System.Drawing.Point(817, 48);
            this.btnExamen.Name = "btnExamen";
            this.btnExamen.Size = new System.Drawing.Size(123, 30);
            this.btnExamen.TabIndex = 5;
            // 
            // btnTrabajos
            // 
            this.btnTrabajos.Location = new System.Drawing.Point(505, 46);
            this.btnTrabajos.Name = "btnTrabajos";
            this.btnTrabajos.Size = new System.Drawing.Size(122, 30);
            this.btnTrabajos.TabIndex = 4;
            // 
            // btnPractica
            // 
            this.btnPractica.Location = new System.Drawing.Point(188, 46);
            this.btnPractica.Name = "btnPractica";
            this.btnPractica.Size = new System.Drawing.Size(123, 30);
            this.btnPractica.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Examen (40%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trabajos (30%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Practica (30%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(454, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculo de Calificacion Final";
            // 
            // FrmEjercicio9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 643);
            this.Controls.Add(this.dgvEvaluaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "FrmEjercicio9";
            this.Text = "FrmEjercicio9";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvaluaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPractica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrabajos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox btnExamen;
        private System.Windows.Forms.TextBox btnTrabajos;
        private System.Windows.Forms.TextBox btnPractica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}