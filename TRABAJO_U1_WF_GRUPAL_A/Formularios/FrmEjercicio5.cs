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
    public partial class FrmEjercicio5 : Form
    {
        private int rondaActual = 1;
        private const int maxRondas = 5;

        private int victoriasJugador = 0;
        private int victoriasComputadora = 0;
        private int empates = 0;
        public FrmEjercicio5()
        {
            InitializeComponent();
        }

        private void FrmEjercicio4_Load(object sender, EventArgs e)
        {
            ReiniciarJuego();
        }
        private void ReiniciarJuego()
        {
            rondaActual = 1;
            victoriasJugador = 0;
            victoriasComputadora = 0;
            empates = 0;

            label5.Text = "0"; 
            label7.Text = "0";
            label9.Text = "0";
            label11.Text = $"{rondaActual} / {maxRondas}";
            label3.Text = "¡Selecciona tu jugada con los botones!"; 

            picJugador.Image = null;
            picComputadora.Image = null;

            HabilitarBotones(true);
        }
        private void BotonJugada_Click(object sender, EventArgs e)
        {
            if (rondaActual > maxRondas) return;

            Button btnSeleccionado = (Button)sender;
            string jugadaUsuario = "";

            if (btnSeleccionado.Name == "btnPiedra")
            {
                jugadaUsuario = "Piedra";
                picJugador.Image = Properties.Resources.Rock;
            }
            else if (btnSeleccionado.Name == "btnPapel")
            {
                jugadaUsuario = "Papel";
                picJugador.Image = Properties.Resources.Paper;
            }
            else if (btnSeleccionado.Name == "btnTijera")
            {
                jugadaUsuario = "Tijera";
                picJugador.Image = Properties.Resources.Scissors;
            }

            string[] opciones = { "Piedra", "Papel", "Tijera" };
            Random rand = new Random();
            int indiceComp = rand.Next(0, 3);
            string jugadaComputadora = opciones[indiceComp];

            if (jugadaComputadora == "Piedra") picComputadora.Image = Properties.Resources.Rock;
            else if (jugadaComputadora == "Papel") picComputadora.Image = Properties.Resources.Paper;
            else if (jugadaComputadora == "Tijera") picComputadora.Image = Properties.Resources.Scissors;

            string resultadoRonda = "";

            if (jugadaUsuario == jugadaComputadora)
            {
                empates++;
                resultadoRonda = $"Empate";
            }
            else if (
                (jugadaUsuario == "Piedra" && jugadaComputadora == "Tijera") ||
                (jugadaUsuario == "Papel" && jugadaComputadora == "Piedra") ||
                (jugadaUsuario == "Tijera" && jugadaComputadora == "Papel")
            )
            {
                victoriasJugador++;
                resultadoRonda = $"¡Ganaste la ronda!";
            }
            else
            {
                victoriasComputadora++;
                resultadoRonda = $"La computadora gana la ronda";
            }

            label3.Text = resultadoRonda;

            label5.Text = victoriasJugador.ToString();
            label7.Text = victoriasComputadora.ToString();
            label9.Text = empates.ToString();

            if (rondaActual < maxRondas)
            {
                rondaActual++;
                label11.Text = $"{rondaActual} / {maxRondas}";
            }
            else
            {
                DeterminarGanadorFinal();
            }
        }
        private void DeterminarGanadorFinal()
        {
            string ganadorFinal = "";

            if (victoriasJugador > victoriasComputadora)
            {
                ganadorFinal = "¡Felicidades, ganaste el juego!";
            }
            else if (victoriasComputadora > victoriasJugador)
            {
                ganadorFinal = "La computadora ganó el juego.";
            }
            else
            {
                ganadorFinal = "El juego terminó en empate general.";
            }

            MessageBox.Show($"FIN DEL JUEGO\n\n" +
                            $"Victorias del Usuario: {victoriasJugador}\n" +
                            $"Victorias de la Computadora: {victoriasComputadora}\n" +
                            $"Empates: {empates}\n\n" +
                            $"{ganadorFinal}",
                            "Resultado Final", MessageBoxButtons.OK, MessageBoxIcon.Information);

            label3.Text = ganadorFinal;
            HabilitarBotones(false);
        }

        private void HabilitarBotones(bool estado)
        {
            btnPiedra.Enabled = estado;
            btnPapel.Enabled = estado;
            btnTijera.Enabled = estado;
        }

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
        }
    }   
}
