namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    partial class FrmEjercicio11
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
            this.grpAccion = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lblResultadoFinal = new System.Windows.Forms.Label();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpAnalisis = new System.Windows.Forms.GroupBox();
            this.lblResultadoVocales = new System.Windows.Forms.Label();
            this.txtPalabraInicial = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAccion.SuspendLayout();
            this.grpAnalisis.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccion
            // 
            this.grpAccion.BackColor = System.Drawing.Color.Honeydew;
            this.grpAccion.Controls.Add(this.label7);
            this.grpAccion.Controls.Add(this.txtPalabra);
            this.grpAccion.Controls.Add(this.label8);
            this.grpAccion.Controls.Add(this.label6);
            this.grpAccion.Controls.Add(this.txtFrase);
            this.grpAccion.Controls.Add(this.lblResultadoFinal);
            this.grpAccion.Controls.Add(this.btnAnalizar);
            this.grpAccion.Controls.Add(this.label4);
            this.grpAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccion.Location = new System.Drawing.Point(162, 252);
            this.grpAccion.Name = "grpAccion";
            this.grpAccion.Size = new System.Drawing.Size(839, 328);
            this.grpAccion.TabIndex = 5;
            this.grpAccion.TabStop = false;
            this.grpAccion.Text = "Accion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ingrese una palabra:";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(239, 184);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(246, 30);
            this.txtPalabra.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Si el numero de vocales es IMPAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ingrese una frase:";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(218, 76);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(373, 30);
            this.txtFrase.TabIndex = 3;
            // 
            // lblResultadoFinal
            // 
            this.lblResultadoFinal.AutoSize = true;
            this.lblResultadoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoFinal.ForeColor = System.Drawing.Color.Green;
            this.lblResultadoFinal.Location = new System.Drawing.Point(32, 269);
            this.lblResultadoFinal.Name = "lblResultadoFinal";
            this.lblResultadoFinal.Size = new System.Drawing.Size(161, 25);
            this.lblResultadoFinal.TabIndex = 2;
            this.lblResultadoFinal.Text = "Resultado final:";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.BackColor = System.Drawing.Color.MistyRose;
            this.btnAnalizar.Location = new System.Drawing.Point(672, 66);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(132, 44);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Si el numero de vocales es PAR";
            // 
            // grpAnalisis
            // 
            this.grpAnalisis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpAnalisis.Controls.Add(this.lblResultadoVocales);
            this.grpAnalisis.Controls.Add(this.txtPalabraInicial);
            this.grpAnalisis.Controls.Add(this.btnEvaluar);
            this.grpAnalisis.Controls.Add(this.label2);
            this.grpAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnalisis.Location = new System.Drawing.Point(106, 88);
            this.grpAnalisis.Name = "grpAnalisis";
            this.grpAnalisis.Size = new System.Drawing.Size(1063, 143);
            this.grpAnalisis.TabIndex = 4;
            this.grpAnalisis.TabStop = false;
            this.grpAnalisis.Text = "Analisis de Palabra inicial";
            // 
            // lblResultadoVocales
            // 
            this.lblResultadoVocales.AutoSize = true;
            this.lblResultadoVocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoVocales.Location = new System.Drawing.Point(768, 48);
            this.lblResultadoVocales.Name = "lblResultadoVocales";
            this.lblResultadoVocales.Size = new System.Drawing.Size(103, 25);
            this.lblResultadoVocales.TabIndex = 3;
            this.lblResultadoVocales.Text = "Vocales: ";
            // 
            // txtPalabraInicial
            // 
            this.txtPalabraInicial.Location = new System.Drawing.Point(263, 50);
            this.txtPalabraInicial.Name = "txtPalabraInicial";
            this.txtPalabraInicial.Size = new System.Drawing.Size(219, 30);
            this.txtPalabraInicial.TabIndex = 2;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEvaluar.Location = new System.Drawing.Point(524, 48);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(196, 42);
            this.btnEvaluar.TabIndex = 1;
            this.btnEvaluar.Text = "Evaluar vocales";
            this.btnEvaluar.UseVisualStyleBackColor = false;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese una palabra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(521, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Analisis de vocales";
            // 
            // FrmEjercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 648);
            this.Controls.Add(this.grpAccion);
            this.Controls.Add(this.grpAnalisis);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio11";
            this.Text = "FrmEjercicio11";
            this.grpAccion.ResumeLayout(false);
            this.grpAccion.PerformLayout();
            this.grpAnalisis.ResumeLayout(false);
            this.grpAnalisis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label lblResultadoFinal;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpAnalisis;
        private System.Windows.Forms.Label lblResultadoVocales;
        private System.Windows.Forms.TextBox txtPalabraInicial;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}