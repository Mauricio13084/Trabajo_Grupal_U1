using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    public partial class FrmEjercicio20 : Form
    {
        private int puntaje = 0;
        private int cartasPedidas = 0;
        private bool rondaTerminada = false;

        private int partidasGanadas = 0;
        private int partidasPerdidas = 0;
        private int partidasJugadas = 0;

        // Generador de números aleatorios
        private Random random = new Random();
        public FrmEjercicio20()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmEjercicio20_Load(object sender, EventArgs e)
        {
            txtPuntaje.Text = "0";
            txtCarta.Text = "—";
            txtCartasPedidas.Text = "0";
            txtGanadas.Text = "0";
            txtPerdidas.Text = "0";
            txtJugadas.Text = "0";
            txtResultado.Text = "Presione 'Pedir Carta' para comenzar";

            // Habilitar/deshabilitar botones
            btnPedir.Enabled = true;
            btnPlantarse.Enabled = true;
            btnNuevaRonda.Enabled = false;

            // Limpiar el ListBox
            lstResumen.Items.Clear();

            rondaTerminada = false;
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            if (rondaTerminada) return;

            // Generar una carta aleatoria entre 1 y 11
            int carta = random.Next(1, 12);

            // Sumar al puntaje
            puntaje += carta;
            cartasPedidas++;

            txtPuntaje.Text = puntaje.ToString();
            txtCarta.Text = carta.ToString();
            txtCartasPedidas.Text = cartasPedidas.ToString();

            lstResumen.Items.Add($"Carta {cartasPedidas}: {carta}  |  Puntaje: {puntaje}");

            if (puntaje > 21)
            {
                txtResultado.Text = $"¡Te pasaste! Puntaje final: {puntaje}";
                lstResumen.Items.Add($"RESULTADO: Te pasaste con {puntaje}");

                lstResumen.ForeColor = Color.Red;

                TerminarRonda(false);
            }
            else if (puntaje == 21)
            {
                txtResultado.Text = "¡GANASTE! Llegaste a 21";
                lstResumen.Items.Add("RESULTADO: ¡GANASTE! Ganaste con 21");

                lstResumen.ForeColor = Color.DarkGreen;

                TerminarRonda(true);
            }
            else
            {
                txtResultado.Text = $"Puntaje actual: {puntaje}. Puedes seguir pidiendo.";
            }
        }

        private void btnPlantarse_Click(object sender, EventArgs e)
        {
            if (rondaTerminada) return;

            // El jugador se planta
            if (puntaje >= 16)
            {
                txtResultado.Text = $"¡Ganaste! Te plantaste con {puntaje}";
                lstResumen.Items.Add($"RESULTADO: Ganaste con {puntaje}");
                lstResumen.ForeColor = Color.DarkGreen;
                TerminarRonda(true);
            }
            else
            {
                txtResultado.Text = $"Te plantaste con {puntaje}. Muy bajo, perdiste.";
                lstResumen.Items.Add($"RESULTADO: Perdiste con {puntaje} (muy bajo)");
                lstResumen.ForeColor = Color.Red;
                TerminarRonda(false);
            }
        }
            private void TerminarRonda(bool gano)
        {
            rondaTerminada = true;

            // Acumular resultado
            if (gano)
                partidasGanadas++;
            else
                partidasPerdidas++;

            partidasJugadas++;

            // Actualizar contadores
            txtGanadas.Text = partidasGanadas.ToString();
            txtPerdidas.Text = partidasPerdidas.ToString();
            txtJugadas.Text = partidasJugadas.ToString();

            btnPedir.Enabled = false;
            btnPlantarse.Enabled = false;
            btnNuevaRonda.Enabled = true;

            // Agregar línea separadora al ListBox
            lstResumen.Items.Add("────────────────────");
        }

        private void btnNuevaRonda_Click(object sender, EventArgs e)
        {
            // Reiniciar variables de la ronda
            puntaje = 0;
            cartasPedidas = 0;
            rondaTerminada = false;

            // Actualizar pantalla
            txtPuntaje.Text = "0";
            txtCarta.Text = "—";
            txtCartasPedidas.Text = "0";
            txtResultado.Text = "Presione 'Pedir Carta' para comenzar";

            // Volver el color del ListBox a negro
            lstResumen.ForeColor = Color.Black;

            // Habilitar/deshabilitar botones
            btnPedir.Enabled = true;
            btnPlantarse.Enabled = true;
            btnNuevaRonda.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
