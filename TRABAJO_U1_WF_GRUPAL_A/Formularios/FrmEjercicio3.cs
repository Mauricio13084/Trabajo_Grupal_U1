using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    public partial class FrmEjercicio3 : Form
    {
        private int numeroSecreto;
        private int intentosRealizados = 0;
        private const int maxIntentos = 10;
        private int puntuacion = 100;
        public FrmEjercicio3()
        {
            InitializeComponent();
        }

        private void FrmEjercicio3_Load(object sender, EventArgs e)
        {
            IniciarNuevoJuego();
        }
        private void IniciarNuevoJuego()
        {
            Random rand = new Random();
            numeroSecreto = rand.Next(1, 101);
            intentosRealizados = 0;
            puntuacion = 100;

            txtNumero.Clear();
            txtNumero.Enabled = true;
            btnIntentar.Enabled = true;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = maxIntentos;
            progressBar1.Value = 0;
        }

        private void btnIntentar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int numeroIngresado) || numeroIngresado < 1 || numeroIngresado > 100)
            {
                MessageBox.Show("Por favor, ingresa un numero valido entre 1 y 100.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return;
            }

            intentosRealizados++;
            progressBar1.Value = intentosRealizados;
            label8.Text = $"{intentosRealizados:00} / {maxIntentos}";
            label5.Text = $"{intentosRealizados:00} / {maxIntentos}";

            if (numeroIngresado == numeroSecreto)
            {
                label10.Text = "¡Correcto!";
                MessageBox.Show($"¡Felicidades! Has adivinado el número secreto en {intentosRealizados} intento(s).", "¡Ganaste! :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FinalizarJuego(true);
            }
            else if (numeroIngresado < numeroSecreto)
            {
                label10.Text = "MAYOR";
                ReducirPuntuacion();
            }
            else
            {
                label10.Text = "MENOR";
                ReducirPuntuacion();
            }

            if (intentosRealizados >= maxIntentos && numeroIngresado != numeroSecreto)
            {
                MessageBox.Show($"¡Se te acabaron los intentos! El número secreto era: {numeroSecreto}", "Perdiste :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FinalizarJuego(false);
            }

            txtNumero.Clear();
            txtNumero.Focus();
        }
        private void ReducirPuntuacion()
        {
            puntuacion -= 10;
            if (puntuacion < 0) puntuacion = 0;
            label9.Text = $"{puntuacion} pts";
        }
        private void FinalizarJuego(bool ganado)
        {
            txtNumero.Enabled = false;
            btnIntentar.Enabled = false;
            label11.Text = numeroSecreto.ToString();
            label12.Text = $"{puntuacion} puntos";
        }

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            IniciarNuevoJuego();
        }
    }
}
