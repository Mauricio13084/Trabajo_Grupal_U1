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
    public partial class FrmEjercicio15 : Form
    {
        private int[] votos = new int[3];

        private int votosEmitidos = 0;
        private int totalVotantes = 0;

        private bool votacionIniciada = false;

        public FrmEjercicio15()
        {
            InitializeComponent();
        }

        private void FrmEjercicio15_Load(object sender, EventArgs e)
        {
            dgvResultados.Columns.Clear();
            dgvResultados.Columns.Add("Candidato", "Candidato");
            dgvResultados.Columns.Add("Votos", "Votos");
            dgvResultados.Columns.Add("Porcentaje", "Porcentaje");
            dgvResultados.Columns[0].Width = 120;
            dgvResultados.Columns[1].Width = 80;
            dgvResultados.Columns[2].Width = 100;
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;

            pbParticipacion.Minimum = 0;
            pbParticipacion.Maximum = 100;
            pbParticipacion.Value = 0;

            txtVotosRegistrados.Text = "0";
            txtVotosRestantes.Text = "0";
            txtGanador.Text = "";

            txtGanador.ReadOnly = false;
            txtGanador.BackColor = Color.Black;
            txtGanador.ForeColor = Color.Yellow;

            nudVotantes.Value = 0;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (!votacionIniciada)
            {
                if (nudVotantes.Value <= 0)
                {
                    MessageBox.Show("Primero ingrese la cantidad de votantes (mayor a 0).",
                        "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                totalVotantes = (int)nudVotantes.Value;
                votacionIniciada = true;
                nudVotantes.Enabled = false;
                txtVotosRestantes.Text = totalVotantes.ToString();
            }

            if (votosEmitidos >= totalVotantes)
            {
                MessageBox.Show($"Ya se registraron todos los votos ({totalVotantes}).",
                    "Votación completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indiceCandidato = -1;
            if (rbCandidato1.Checked) indiceCandidato = 0;
            else if (rbCandidato2.Checked) indiceCandidato = 1;
            else if (rbCandidato3.Checked) indiceCandidato = 2;

            if (indiceCandidato == -1)
            {
                MessageBox.Show("Seleccione un candidato antes de votar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            votos[indiceCandidato]++;
            votosEmitidos++;

            txtVotosRegistrados.Text = votosEmitidos.ToString();
            txtVotosRestantes.Text = (totalVotantes - votosEmitidos).ToString();

            rbCandidato1.Checked = false;
            rbCandidato2.Checked = false;
            rbCandidato3.Checked = false;

            MostrarResultados();

            if (votosEmitidos == totalVotantes)
            {
                MessageBox.Show("¡Votación finalizada! Revise los resultados.",
                    "Votación completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MostrarResultados()
        {

            if (votosEmitidos == 0)
            {
                MessageBox.Show("Aún no se han registrado votos.");
                return;
            }

            dgvResultados.Rows.Clear();

            int maxVotos = -1;
            int indiceGanador = -1;

            for (int i = 0; i < votos.Length; i++)
            {
                double porcentaje = (double)votos[i] / votosEmitidos * 100;

                dgvResultados.Rows.Add("Candidato " + (i + 1), votos[i], porcentaje.ToString("F2") + " %");

                if (votos[i] > maxVotos)
                {
                    maxVotos = votos[i];
                    indiceGanador = i;
                }
            }


            int contadorGanadores = 0;
            for (int i = 0; i < votos.Length; i++)
            {
                if (votos[i] == maxVotos) contadorGanadores++;
            }

            if (contadorGanadores > 1)
            {
                txtGanador.Text = "EMPATE";
                txtGanador.ForeColor = Color.Yellow;
            }
            else
            {
                txtGanador.Text = "Candidato " + (indiceGanador + 1) + " (" + maxVotos + " votos)";
                txtGanador.ForeColor = Color.Yellow;
            }

            int porcentajeParticipacion = (int)((double)votosEmitidos / totalVotantes * 100);
            pbParticipacion.Value = porcentajeParticipacion;
        }

        

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < votos.Length; i++) votos[i] = 0;
            votosEmitidos = 0;
            totalVotantes = 0;
            votacionIniciada = false;
            txtVotosRegistrados.Text = "0";
            txtVotosRestantes.Text = "0";
            txtGanador.Clear();
            txtGanador.ForeColor = Color.Yellow;
            dgvResultados.Rows.Clear();
            pbParticipacion.Value = 0;
            nudVotantes.Enabled = true;
            nudVotantes.Value = 0;
            rbCandidato1.Checked = false;
            rbCandidato2.Checked = false;
            rbCandidato3.Checked = false;

            tabControl1.SelectedTab = tabVotacion;

            MessageBox.Show("Sistema reiniciado. Ingrese la nueva cantidad de votantes.",
                "Reiniciar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
