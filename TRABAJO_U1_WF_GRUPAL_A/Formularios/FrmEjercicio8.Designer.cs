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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjercicio8));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvResumenCursos = new System.Windows.Forms.DataGridView();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesaprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.colEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenCursos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox4.Controls.Add(this.dgvResumenCursos);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(552, 285);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(376, 207);
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
            this.dgvResumenCursos.Location = new System.Drawing.Point(12, 28);
            this.dgvResumenCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvResumenCursos.Name = "dgvResumenCursos";
            this.dgvResumenCursos.ReadOnly = true;
            this.dgvResumenCursos.RowHeadersVisible = false;
            this.dgvResumenCursos.RowHeadersWidth = 51;
            this.dgvResumenCursos.RowTemplate.Height = 24;
            this.dgvResumenCursos.Size = new System.Drawing.Size(351, 161);
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
            this.groupBox3.Location = new System.Drawing.Point(511, 262);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(6, 6);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.dgvNotas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 282);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(530, 210);
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
            this.dgvNotas.Location = new System.Drawing.Point(4, 21);
            this.dgvNotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowHeadersVisible = false;
            this.dgvNotas.RowHeadersWidth = 51;
            this.dgvNotas.RowTemplate.Height = 24;
            this.dgvNotas.Size = new System.Drawing.Size(510, 171);
            this.dgvNotas.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(725, 122);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion de Estudiantes";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(207, 40);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(108, 26);
            this.txtCantidad.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalcular.Location = new System.Drawing.Point(578, 36);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 33);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGenerar.Location = new System.Drawing.Point(442, 36);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(98, 33);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Matriz";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de estudiantes:";
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
            this.label15.Location = new System.Drawing.Point(344, 16);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(421, 31);
            this.label15.TabIndex = 37;
            this.label15.Text = "MATRIZ DE CALIFICACIONES";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.Location = new System.Drawing.Point(-2, -1);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(973, 63);
            this.textBox1.TabIndex = 36;
            // 
            // FrmEjercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 514);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEjercicio8";
            this.Text = "FrmEjercicio8";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenCursos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
    }
}