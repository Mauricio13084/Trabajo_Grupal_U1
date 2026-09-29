namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    partial class FrmEjercicio6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjercicio6));
            this.grpDesglose = new System.Windows.Forms.GroupBox();
            this.dgvDenominacion = new System.Windows.Forms.DataGridView();
            this.colDenominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOperacion = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpResumenCuenta = new System.Windows.Forms.GroupBox();
            this.lblMontoRetirado = new System.Windows.Forms.Label();
            this.lblSaldoRestante = new System.Windows.Forms.Label();
            this.lblSaldoAnterior = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpDesglose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenominacion)).BeginInit();
            this.grpOperacion.SuspendLayout();
            this.grpResumenCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDesglose
            // 
            this.grpDesglose.BackColor = System.Drawing.Color.AliceBlue;
            this.grpDesglose.Controls.Add(this.dgvDenominacion);
            this.grpDesglose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDesglose.Location = new System.Drawing.Point(537, 246);
            this.grpDesglose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDesglose.Name = "grpDesglose";
            this.grpDesglose.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDesglose.Size = new System.Drawing.Size(309, 332);
            this.grpDesglose.TabIndex = 11;
            this.grpDesglose.TabStop = false;
            this.grpDesglose.Text = "Desglose de billetes";
            // 
            // dgvDenominacion
            // 
            this.dgvDenominacion.AllowUserToAddRows = false;
            this.dgvDenominacion.AllowUserToDeleteRows = false;
            this.dgvDenominacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDenominacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDenominacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDenominacion,
            this.colCantidad});
            this.dgvDenominacion.Location = new System.Drawing.Point(18, 35);
            this.dgvDenominacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDenominacion.Name = "dgvDenominacion";
            this.dgvDenominacion.ReadOnly = true;
            this.dgvDenominacion.RowHeadersVisible = false;
            this.dgvDenominacion.RowHeadersWidth = 51;
            this.dgvDenominacion.RowTemplate.Height = 24;
            this.dgvDenominacion.Size = new System.Drawing.Size(255, 292);
            this.dgvDenominacion.TabIndex = 0;
            // 
            // colDenominacion
            // 
            this.colDenominacion.HeaderText = "Denominacion";
            this.colDenominacion.MinimumWidth = 6;
            this.colDenominacion.Name = "colDenominacion";
            this.colDenominacion.ReadOnly = true;
            this.colDenominacion.Width = 151;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 125;
            // 
            // grpOperacion
            // 
            this.grpOperacion.BackColor = System.Drawing.Color.Thistle;
            this.grpOperacion.Controls.Add(this.btnLimpiar);
            this.grpOperacion.Controls.Add(this.btnRetirar);
            this.grpOperacion.Controls.Add(this.txtMonto);
            this.grpOperacion.Controls.Add(this.label2);
            this.grpOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperacion.Location = new System.Drawing.Point(178, 85);
            this.grpOperacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOperacion.Name = "grpOperacion";
            this.grpOperacion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOperacion.Size = new System.Drawing.Size(698, 132);
            this.grpOperacion.TabIndex = 9;
            this.grpOperacion.TabStop = false;
            this.grpOperacion.Text = "Operacion de retiro";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(508, 41);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 30);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(360, 41);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(104, 30);
            this.btnRetirar.TabIndex = 4;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(117, 46);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(122, 26);
            this.txtMonto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto (S/)";
            // 
            // grpResumenCuenta
            // 
            this.grpResumenCuenta.BackColor = System.Drawing.Color.LavenderBlush;
            this.grpResumenCuenta.Controls.Add(this.lblMontoRetirado);
            this.grpResumenCuenta.Controls.Add(this.lblSaldoRestante);
            this.grpResumenCuenta.Controls.Add(this.lblSaldoAnterior);
            this.grpResumenCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResumenCuenta.Location = new System.Drawing.Point(178, 255);
            this.grpResumenCuenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpResumenCuenta.Name = "grpResumenCuenta";
            this.grpResumenCuenta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpResumenCuenta.Size = new System.Drawing.Size(331, 282);
            this.grpResumenCuenta.TabIndex = 10;
            this.grpResumenCuenta.TabStop = false;
            this.grpResumenCuenta.Text = "Resumen de cuenta";
            // 
            // lblMontoRetirado
            // 
            this.lblMontoRetirado.AutoSize = true;
            this.lblMontoRetirado.Location = new System.Drawing.Point(30, 100);
            this.lblMontoRetirado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoRetirado.Name = "lblMontoRetirado";
            this.lblMontoRetirado.Size = new System.Drawing.Size(116, 20);
            this.lblMontoRetirado.TabIndex = 2;
            this.lblMontoRetirado.Text = "Monto retirado:";
            // 
            // lblSaldoRestante
            // 
            this.lblSaldoRestante.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblSaldoRestante.AutoSize = true;
            this.lblSaldoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoRestante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSaldoRestante.Location = new System.Drawing.Point(30, 157);
            this.lblSaldoRestante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldoRestante.Name = "lblSaldoRestante";
            this.lblSaldoRestante.Size = new System.Drawing.Size(132, 20);
            this.lblSaldoRestante.TabIndex = 1;
            this.lblSaldoRestante.Text = "Saldo restante:";
            // 
            // lblSaldoAnterior
            // 
            this.lblSaldoAnterior.AutoSize = true;
            this.lblSaldoAnterior.Location = new System.Drawing.Point(30, 50);
            this.lblSaldoAnterior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldoAnterior.Name = "lblSaldoAnterior";
            this.lblSaldoAnterior.Size = new System.Drawing.Size(112, 20);
            this.lblSaldoAnterior.TabIndex = 0;
            this.lblSaldoAnterior.Text = "Saldo anterior:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.SteelBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(64, 33);
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
            this.label14.Location = new System.Drawing.Point(64, 17);
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
            this.pictureBox2.Location = new System.Drawing.Point(17, 3);
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
            this.label15.Location = new System.Drawing.Point(342, 17);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(331, 31);
            this.label15.TabIndex = 37;
            this.label15.Text = "CAJERO AUTOMATICO";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.Location = new System.Drawing.Point(-4, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1007, 63);
            this.textBox1.TabIndex = 36;
            // 
            // FrmEjercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 595);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpResumenCuenta);
            this.Controls.Add(this.grpDesglose);
            this.Controls.Add(this.grpOperacion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEjercicio6";
            this.Text = "FrmEjercicio6";
            this.grpDesglose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenominacion)).EndInit();
            this.grpOperacion.ResumeLayout(false);
            this.grpOperacion.PerformLayout();
            this.grpResumenCuenta.ResumeLayout(false);
            this.grpResumenCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDesglose;
        private System.Windows.Forms.GroupBox grpOperacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpResumenCuenta;
        private System.Windows.Forms.Label lblMontoRetirado;
        private System.Windows.Forms.Label lblSaldoRestante;
        private System.Windows.Forms.Label lblSaldoAnterior;
        private System.Windows.Forms.DataGridView dgvDenominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDenominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
    }
}