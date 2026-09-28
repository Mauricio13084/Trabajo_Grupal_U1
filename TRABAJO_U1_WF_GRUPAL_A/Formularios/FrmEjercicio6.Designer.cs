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
            this.grpDesglose = new System.Windows.Forms.GroupBox();
            this.grpOperacion = new System.Windows.Forms.GroupBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpResumenCuenta = new System.Windows.Forms.GroupBox();
            this.lblSaldoAnterior = new System.Windows.Forms.Label();
            this.lblSaldoRestante = new System.Windows.Forms.Label();
            this.lblMontoRetirado = new System.Windows.Forms.Label();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDenominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDenominacion = new System.Windows.Forms.DataGridView();
            this.grpDesglose.SuspendLayout();
            this.grpOperacion.SuspendLayout();
            this.grpResumenCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenominacion)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDesglose
            // 
            this.grpDesglose.BackColor = System.Drawing.Color.AliceBlue;
            this.grpDesglose.Controls.Add(this.dgvDenominacion);
            this.grpDesglose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDesglose.Location = new System.Drawing.Point(715, 280);
            this.grpDesglose.Name = "grpDesglose";
            this.grpDesglose.Size = new System.Drawing.Size(412, 408);
            this.grpDesglose.TabIndex = 11;
            this.grpDesglose.TabStop = false;
            this.grpDesglose.Text = "Desglose de billetes";
            // 
            // grpOperacion
            // 
            this.grpOperacion.BackColor = System.Drawing.Color.Thistle;
            this.grpOperacion.Controls.Add(this.btnLimpiar);
            this.grpOperacion.Controls.Add(this.btnRetirar);
            this.grpOperacion.Controls.Add(this.txtMonto);
            this.grpOperacion.Controls.Add(this.label2);
            this.grpOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperacion.Location = new System.Drawing.Point(236, 83);
            this.grpOperacion.Name = "grpOperacion";
            this.grpOperacion.Size = new System.Drawing.Size(931, 163);
            this.grpOperacion.TabIndex = 9;
            this.grpOperacion.TabStop = false;
            this.grpOperacion.Text = "Operacion de retiro";
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(480, 50);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(138, 37);
            this.btnRetirar.TabIndex = 4;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(156, 57);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(161, 30);
            this.txtMonto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto (S/)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(492, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Simulador Cajero Automatico";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(678, 50);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(138, 37);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpResumenCuenta
            // 
            this.grpResumenCuenta.BackColor = System.Drawing.Color.LavenderBlush;
            this.grpResumenCuenta.Controls.Add(this.lblMontoRetirado);
            this.grpResumenCuenta.Controls.Add(this.lblSaldoRestante);
            this.grpResumenCuenta.Controls.Add(this.lblSaldoAnterior);
            this.grpResumenCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResumenCuenta.Location = new System.Drawing.Point(236, 292);
            this.grpResumenCuenta.Name = "grpResumenCuenta";
            this.grpResumenCuenta.Size = new System.Drawing.Size(441, 347);
            this.grpResumenCuenta.TabIndex = 10;
            this.grpResumenCuenta.TabStop = false;
            this.grpResumenCuenta.Text = "Resumen de cuenta";
            // 
            // lblSaldoAnterior
            // 
            this.lblSaldoAnterior.AutoSize = true;
            this.lblSaldoAnterior.Location = new System.Drawing.Point(40, 62);
            this.lblSaldoAnterior.Name = "lblSaldoAnterior";
            this.lblSaldoAnterior.Size = new System.Drawing.Size(139, 25);
            this.lblSaldoAnterior.TabIndex = 0;
            this.lblSaldoAnterior.Text = "Saldo anterior:";
            // 
            // lblSaldoRestante
            // 
            this.lblSaldoRestante.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblSaldoRestante.AutoSize = true;
            this.lblSaldoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoRestante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSaldoRestante.Location = new System.Drawing.Point(40, 193);
            this.lblSaldoRestante.Name = "lblSaldoRestante";
            this.lblSaldoRestante.Size = new System.Drawing.Size(159, 25);
            this.lblSaldoRestante.TabIndex = 1;
            this.lblSaldoRestante.Text = "Saldo restante:";
            // 
            // lblMontoRetirado
            // 
            this.lblMontoRetirado.AutoSize = true;
            this.lblMontoRetirado.Location = new System.Drawing.Point(40, 123);
            this.lblMontoRetirado.Name = "lblMontoRetirado";
            this.lblMontoRetirado.Size = new System.Drawing.Size(143, 25);
            this.lblMontoRetirado.TabIndex = 2;
            this.lblMontoRetirado.Text = "Monto retirado:";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 125;
            // 
            // colDenominacion
            // 
            this.colDenominacion.HeaderText = "Denominacion";
            this.colDenominacion.MinimumWidth = 6;
            this.colDenominacion.Name = "colDenominacion";
            this.colDenominacion.ReadOnly = true;
            this.colDenominacion.Width = 151;
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
            this.dgvDenominacion.Location = new System.Drawing.Point(24, 43);
            this.dgvDenominacion.Name = "dgvDenominacion";
            this.dgvDenominacion.ReadOnly = true;
            this.dgvDenominacion.RowHeadersVisible = false;
            this.dgvDenominacion.RowHeadersWidth = 51;
            this.dgvDenominacion.RowTemplate.Height = 24;
            this.dgvDenominacion.Size = new System.Drawing.Size(340, 359);
            this.dgvDenominacion.TabIndex = 0;
            // 
            // FrmEjercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 714);
            this.Controls.Add(this.grpResumenCuenta);
            this.Controls.Add(this.grpDesglose);
            this.Controls.Add(this.grpOperacion);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio6";
            this.Text = "FrmEjercicio6";
            this.grpDesglose.ResumeLayout(false);
            this.grpOperacion.ResumeLayout(false);
            this.grpOperacion.PerformLayout();
            this.grpResumenCuenta.ResumeLayout(false);
            this.grpResumenCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenominacion)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpResumenCuenta;
        private System.Windows.Forms.Label lblMontoRetirado;
        private System.Windows.Forms.Label lblSaldoRestante;
        private System.Windows.Forms.Label lblSaldoAnterior;
        private System.Windows.Forms.DataGridView dgvDenominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDenominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
    }
}