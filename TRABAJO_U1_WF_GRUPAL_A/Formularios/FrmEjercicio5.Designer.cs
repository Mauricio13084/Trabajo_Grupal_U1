namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    partial class FrmEjercicio5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjercicio5));
            this.btnPiedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTijera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNuevoJuego = new System.Windows.Forms.Button();
            this.picJugador = new System.Windows.Forms.PictureBox();
            this.picComputadora = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputadora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPiedra
            // 
            this.btnPiedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPiedra.BackgroundImage")));
            this.btnPiedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPiedra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPiedra.Location = new System.Drawing.Point(231, 138);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(160, 140);
            this.btnPiedra.TabIndex = 0;
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.BotonJugada_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPapel.BackgroundImage")));
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Location = new System.Drawing.Point(433, 138);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(160, 140);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.BotonJugada_Click);
            // 
            // btnTijera
            // 
            this.btnTijera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTijera.BackgroundImage")));
            this.btnTijera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTijera.Location = new System.Drawing.Point(637, 138);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(160, 140);
            this.btnTijera.TabIndex = 2;
            this.btnTijera.UseVisualStyleBackColor = true;
            this.btnTijera.Click += new System.EventHandler(this.BotonJugada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "JUGADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(771, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "COMPUTADORA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Victorias del Jugador: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(719, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Victorias de la Computadora: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(842, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "Empates: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(498, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 30);
            this.label9.TabIndex = 11;
            this.label9.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 630);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 30);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ronda Actual: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(209, 630);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 30);
            this.label11.TabIndex = 13;
            this.label11.Text = "-";
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNuevoJuego.FlatAppearance.BorderSize = 0;
            this.btnNuevoJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoJuego.Location = new System.Drawing.Point(776, 630);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(148, 37);
            this.btnNuevoJuego.TabIndex = 16;
            this.btnNuevoJuego.Text = "NUEVO JUEGO";
            this.btnNuevoJuego.UseVisualStyleBackColor = false;
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
            // 
            // picJugador
            // 
            this.picJugador.Location = new System.Drawing.Point(86, 360);
            this.picJugador.Name = "picJugador";
            this.picJugador.Size = new System.Drawing.Size(160, 140);
            this.picJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJugador.TabIndex = 17;
            this.picJugador.TabStop = false;
            // 
            // picComputadora
            // 
            this.picComputadora.Location = new System.Drawing.Point(776, 360);
            this.picComputadora.Name = "picComputadora";
            this.picComputadora.Size = new System.Drawing.Size(160, 140);
            this.picComputadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputadora.TabIndex = 18;
            this.picComputadora.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(349, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(330, 37);
            this.label13.TabIndex = 19;
            this.label13.Text = "PIEDRA, PAPEL O TIJERA";
            // 
            // FrmEjercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1037, 682);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.picComputadora);
            this.Controls.Add(this.picJugador);
            this.Controls.Add(this.btnNuevoJuego);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTijera);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPiedra);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEjercicio4";
            this.Text = "FrmEjercicio4";
            this.Load += new System.EventHandler(this.FrmEjercicio4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTijera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNuevoJuego;
        private System.Windows.Forms.PictureBox picJugador;
        private System.Windows.Forms.PictureBox picComputadora;
        private System.Windows.Forms.Label label13;
    }
}