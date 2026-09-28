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
        // ===== ARREGLO DE VOTOS (Condición del enunciado) =====
        // Índice 0 = Candidato 1, Índice 1 = Candidato 2, Índice 2 = Candidato 3
        private int[] votos = new int[3];

        // Contadores
        private int votosEmitidos = 0;
        private int totalVotantes = 0;

        // Bandera para saber si la votación ya inició
        private bool votacionIniciada = false;

        public FrmEjercicio15()
        {
            InitializeComponent();
        }

        private void FrmEjercicio15_Load(object sender, EventArgs e)
        {
            // Configurar DataGridView
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

            // Configurar ProgressBar
            pbParticipacion.Minimum = 0;
            pbParticipacion.Maximum = 100;
            pbParticipacion.Value = 0;

            // Inicializar TextBox
            txtVotosRegistrados.Text = "0";
            txtVotosRestantes.Text = "0";
            txtGanador.Text = "";

            txtGanador.ReadOnly = false;     // Permitir cambio de color
            txtGanador.BackColor = Color.Black;
            txtGanador.ForeColor = Color.Yellow;

            // Inicializar NumericUpDown
            nudVotantes.Value = 0;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            // 1. INICIAR LA VOTACIÓN (solo la primera vez)
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

            // 2. VALIDAR QUE NO SE EXCEDAN LOS VOTOS
            if (votosEmitidos >= totalVotantes)
            {
                MessageBox.Show($"Ya se registraron todos los votos ({totalVotantes}).",
                    "Votación completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. VALIDAR QUE SE HAYA SELECCIONADO UN CANDIDATO
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

            // 4. REGISTRAR EL VOTO EN EL ARREGLO
            votos[indiceCandidato]++;
            votosEmitidos++;

            // 5. ACTUALIZAR CONTADORES VISUALES
            txtVotosRegistrados.Text = votosEmitidos.ToString();
            txtVotosRestantes.Text = (totalVotantes - votosEmitidos).ToString();

            // 6. DESMARCAR RADIOBUTTONS
            rbCandidato1.Checked = false;
            rbCandidato2.Checked = false;
            rbCandidato3.Checked = false;

            // 7. ACTUALIZAR RESULTADOS EN TIEMPO REAL
            MostrarResultados();

            // 8. SI YA SE COMPLETARON LOS VOTOS, AVISAR
            if (votosEmitidos == totalVotantes)
            {
                MessageBox.Show("¡Votación finalizada! Revise los resultados.",
                    "Votación completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ===== MÉTODO PARA MOSTRAR RESULTADOS =====
        private void MostrarResultados()
        {
            // Validar que haya votos
            if (votosEmitidos == 0)
            {
                MessageBox.Show("Aún no se han registrado votos.");
                return;
            }

            // 1. LIMPIAR EL DATAGRIDVIEW
            dgvResultados.Rows.Clear();

            // 2. RECORRER EL ARREGLO (Condición del enunciado: estructuras repetitivas)
            int maxVotos = -1;
            int indiceGanador = -1;

            for (int i = 0; i < votos.Length; i++)
            {
                // Calcular porcentaje
                double porcentaje = (double)votos[i] / votosEmitidos * 100;

                // Agregar fila al DataGridView
                dgvResultados.Rows.Add("Candidato " + (i + 1), votos[i], porcentaje.ToString("F2") + " %");

                // Determinar ganador
                if (votos[i] > maxVotos)
                {
                    maxVotos = votos[i];
                    indiceGanador = i;
                }
            }

            // 3. VERIFICAR EMPATE
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

            // 4. ACTUALIZAR PROGRESSBAR
            int porcentajeParticipacion = (int)((double)votosEmitidos / totalVotantes * 100);
            pbParticipacion.Value = porcentajeParticipacion;
        }

        

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Limpiar arreglo y contadores
            for (int i = 0; i < votos.Length; i++) votos[i] = 0;
            votosEmitidos = 0;
            totalVotantes = 0;
            votacionIniciada = false;

            // Limpiar controles
            txtVotosRegistrados.Text = "0";
            txtVotosRestantes.Text = "0";
            txtGanador.Clear();
            txtGanador.ForeColor = Color.Yellow;
            dgvResultados.Rows.Clear();
            pbParticipacion.Value = 0;

            // Desbloquear NumericUpDown
            nudVotantes.Enabled = true;
            nudVotantes.Value = 0;

            // Desmarcar RadioButtons
            rbCandidato1.Checked = false;
            rbCandidato2.Checked = false;
            rbCandidato3.Checked = false;

            // Volver a pestaña de votación
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
