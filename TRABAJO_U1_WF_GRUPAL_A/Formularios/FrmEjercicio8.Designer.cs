namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    partial class FrmEjercicio8
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvResumenCursos = new System.Windows.Forms.DataGridView();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesaprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.colEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenCursos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox4.Controls.Add(this.dgvResumenCursos);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(736, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 255);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estadisticas por curso";
            // 
            // dgvResumenCursos
            // 
            this.dgvResumenCursos.AllowUserToAddRows = false;
            this.dgvResumenCursos.AllowUserToDeleteRows = false;
            this.dgvResumenCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResumenCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResumenCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCurso,
            this.colProm,
            this.colAprobado,
            this.colDesaprobado});
            this.dgvResumenCursos.Location = new System.Drawing.Point(16, 34);
            this.dgvResumenCursos.Name = "dgvResumenCursos";
            this.dgvResumenCursos.ReadOnly = true;
            this.dgvResumenCursos.RowHeadersVisible = false;
            this.dgvResumenCursos.RowHeadersWidth = 51;
            this.dgvResumenCursos.RowTemplate.Height = 24;
            this.dgvResumenCursos.Size = new System.Drawing.Size(468, 198);
            this.dgvResumenCursos.TabIndex = 0;
            // 
            // colCurso
            // 
            this.colCurso.HeaderText = "Curso";
            this.colCurso.MinimumWidth = 6;
            this.colCurso.Name = "colCurso";
            this.colCurso.ReadOnly = true;
            // 
            // colProm
            // 
            this.colProm.HeaderText = "Promedio";
            this.colProm.MinimumWidth = 6;
            this.colProm.Name = "colProm";
            this.colProm.ReadOnly = true;
            // 
            // colAprobado
            // 
            this.colAprobado.HeaderText = "Aprobado";
            this.colAprobado.MinimumWidth = 6;
            this.colAprobado.Name = "colAprobado";
            this.colAprobado.ReadOnly = true;
            // 
            // colDesaprobado
            // 
            this.colDesaprobado.HeaderText = "Desaprobado";
            this.colDesaprobado.MinimumWidth = 6;
            this.colDesaprobado.Name = "colDesaprobado";
            this.colDesaprobado.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(681, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(8, 8);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.dgvNotas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 259);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEstudiante,
            this.colCurso1,
            this.colCurso2,
            this.colCurso3,
            this.colCurso4,
            this.colCurso5,
            this.colPromedio});
            this.dgvNotas.Location = new System.Drawing.Point(6, 26);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowHeadersVisible = false;
            this.dgvNotas.RowHeadersWidth = 51;
            this.dgvNotas.RowTemplate.Height = 24;
            this.dgvNotas.Size = new System.Drawing.Size(680, 210);
            this.dgvNotas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(120, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion de Estudiantes";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalcular.Location = new System.Drawing.Point(771, 44);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(130, 41);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGenerar.Location = new System.Drawing.Point(589, 44);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(130, 41);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Matriz";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de estudiantes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(486, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matriz de Calificaciones";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(276, 49);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(143, 30);
            this.txtCantidad.TabIndex = 4;
            // 
            // colEstudiante
            // 
            this.colEstudiante.FillWeight = 164.8351F;
            this.colEstudiante.HeaderText = "Estudiante";
            this.colEstudiante.MinimumWidth = 6;
            this.colEstudiante.Name = "colEstudiante";
            this.colEstudiante.ReadOnly = true;
            this.colEstudiante.Width = 150;
            // 
            // colCurso1
            // 
            this.colCurso1.FillWeight = 85.58344F;
            this.colCurso1.HeaderText = "C1";
            this.colCurso1.MinimumWidth = 6;
            this.colCurso1.Name = "colCurso1";
            this.colCurso1.ReadOnly = true;
            this.colCurso1.Width = 50;
            // 
            // colCurso2
            // 
            this.colCurso2.FillWeight = 99.31573F;
            this.colCurso2.HeaderText = "C2";
            this.colCurso2.MinimumWidth = 6;
            this.colCurso2.Name = "colCurso2";
            this.colCurso2.ReadOnly = true;
            this.colCurso2.Width = 50;
            // 
            // colCurso3
            // 
            this.colCurso3.FillWeight = 90.07803F;
            this.colCurso3.HeaderText = "C3";
            this.colCurso3.MinimumWidth = 6;
            this.colCurso3.Name = "colCurso3";
            this.colCurso3.ReadOnly = true;
            this.colCurso3.Width = 50;
            // 
            // colCurso4
            // 
            this.colCurso4.FillWeight = 81.78294F;
            this.colCurso4.HeaderText = "C4";
            this.colCurso4.MinimumWidth = 6;
            this.colCurso4.Name = "colCurso4";
            this.colCurso4.ReadOnly = true;
            this.colCurso4.Width = 50;
            // 
            // colCurso5
            // 
            this.colCurso5.FillWeight = 74.33429F;
            this.colCurso5.HeaderText = "C5";
            this.colCurso5.MinimumWidth = 6;
            this.colCurso5.Name = "colCurso5";
            this.colCurso5.ReadOnly = true;
            this.colCurso5.Width = 50;
            // 
            // colPromedio
            // 
            this.colPromedio.FillWeight = 104.0703F;
            this.colPromedio.HeaderText = "Promedio";
            this.colPromedio.MinimumWidth = 6;
            this.colPromedio.Name = "colPromedio";
            this.colPromedio.ReadOnly = true;
            this.colPromedio.Width = 95;
            // 
            // FrmEjercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 632);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio8";
            this.Text = "FrmEjercicio8";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenCursos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvResumenCursos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesaprobado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromedio;
    }
}