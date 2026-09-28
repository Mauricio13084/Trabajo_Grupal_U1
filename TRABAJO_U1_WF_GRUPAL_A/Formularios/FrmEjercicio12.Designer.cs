namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    partial class FrmEjercicio12
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
            this.grpResumen = new System.Windows.Forms.GroupBox();
            this.lblCountNumeros = new System.Windows.Forms.Label();
            this.lblCountFizzBuzz = new System.Windows.Forms.Label();
            this.lblCountBuzz = new System.Windows.Forms.Label();
            this.lblCountFizz = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpResumen
            // 
            this.grpResumen.BackColor = System.Drawing.Color.Azure;
            this.grpResumen.Controls.Add(this.lblCountNumeros);
            this.grpResumen.Controls.Add(this.lblCountFizzBuzz);
            this.grpResumen.Controls.Add(this.lblCountBuzz);
            this.grpResumen.Controls.Add(this.lblCountFizz);
            this.grpResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResumen.Location = new System.Drawing.Point(646, 145);
            this.grpResumen.Name = "grpResumen";
            this.grpResumen.Size = new System.Drawing.Size(453, 425);
            this.grpResumen.TabIndex = 9;
            this.grpResumen.TabStop = false;
            this.grpResumen.Text = "Resumen";
            // 
            // lblCountNumeros
            // 
            this.lblCountNumeros.AutoSize = true;
            this.lblCountNumeros.ForeColor = System.Drawing.Color.Teal;
            this.lblCountNumeros.Location = new System.Drawing.Point(45, 225);
            this.lblCountNumeros.Name = "lblCountNumeros";
            this.lblCountNumeros.Size = new System.Drawing.Size(205, 25);
            this.lblCountNumeros.TabIndex = 3;
            this.lblCountNumeros.Text = "Numeros sin cambios:";
            // 
            // lblCountFizzBuzz
            // 
            this.lblCountFizzBuzz.AutoSize = true;
            this.lblCountFizzBuzz.ForeColor = System.Drawing.Color.Teal;
            this.lblCountFizzBuzz.Location = new System.Drawing.Point(45, 169);
            this.lblCountFizzBuzz.Name = "lblCountFizzBuzz";
            this.lblCountFizzBuzz.Size = new System.Drawing.Size(169, 25);
            this.lblCountFizzBuzz.TabIndex = 2;
            this.lblCountFizzBuzz.Text = "Multiplos de 3 y 5:";
            // 
            // lblCountBuzz
            // 
            this.lblCountBuzz.AutoSize = true;
            this.lblCountBuzz.ForeColor = System.Drawing.Color.Teal;
            this.lblCountBuzz.Location = new System.Drawing.Point(45, 110);
            this.lblCountBuzz.Name = "lblCountBuzz";
            this.lblCountBuzz.Size = new System.Drawing.Size(138, 25);
            this.lblCountBuzz.TabIndex = 1;
            this.lblCountBuzz.Text = "Multiplos de 5:";
            // 
            // lblCountFizz
            // 
            this.lblCountFizz.AutoSize = true;
            this.lblCountFizz.ForeColor = System.Drawing.Color.Teal;
            this.lblCountFizz.Location = new System.Drawing.Point(45, 52);
            this.lblCountFizz.Name = "lblCountFizz";
            this.lblCountFizz.Size = new System.Drawing.Size(138, 25);
            this.lblCountFizz.TabIndex = 0;
            this.lblCountFizz.Text = "Multiplos de 3:";
            // 
            // lstResultados
            // 
            this.lstResultados.BackColor = System.Drawing.Color.LightCyan;
            this.lstResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 25;
            this.lstResultados.Location = new System.Drawing.Point(213, 145);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(400, 429);
            this.lstResultados.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(825, 79);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(146, 43);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(422, 79);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(161, 43);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar Fizz Buzz";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(555, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Secuencia FizzBuzz";
            // 
            // FrmEjercicio12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 582);
            this.Controls.Add(this.grpResumen);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio12";
            this.Text = "FrmEjercicio12";
            this.grpResumen.ResumeLayout(false);
            this.grpResumen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpResumen;
        private System.Windows.Forms.Label lblCountNumeros;
        private System.Windows.Forms.Label lblCountFizzBuzz;
        private System.Windows.Forms.Label lblCountBuzz;
        private System.Windows.Forms.Label lblCountFizz;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
    }
}