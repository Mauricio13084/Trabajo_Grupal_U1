using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    public partial class FrmEjercicio10 : Form
    {
        private const int NUM_TURNOS = 4;
        private const int NUM_ESPECIALIDADES = 4;
        private const double NOTA_MINIMA_TURNO = 4.0;

        private readonly string[] especialidades = { "Pediatria", "Ginecologia", "Internista", "Neurologia" };

        
        private readonly double[,] datosIniciales =
        {
            { 3.2, 4.3, 4.8, 2.5 },   // Turno 1
            { 4.1, 4.0, 4.2, 4.0 },   // Turno 2
            { 3.7, 3.8, 4.5, 3.8 },   // Turno 3
            { 3.8, 4.3, 4.4, 3.0 }    // Turno 4
        };
        public FrmEjercicio10()
        {
            InitializeComponent();
            
            dgvEvaluacion.AllowUserToAddRows = false;
            dgvEvaluacion.ReadOnly = false;
            colTurno.ReadOnly = true;
            colPediatria.ReadOnly = false;
            colGinecologia.ReadOnly = false;
            colInternista.ReadOnly = false;
            colNeurologia.ReadOnly = false;

            dgvPromedioEspecialidad.AllowUserToAddRows = false;

            CargarTabla();
        }


        private void CargarTabla()
        {
            dgvEvaluacion.Rows.Clear();

            for (int t = 0; t < NUM_TURNOS; t++)
            {
                int fila = dgvEvaluacion.Rows.Add();
                dgvEvaluacion.Rows[fila].Cells[0].Value = "Turno " + (t + 1);

                for (int e = 0; e < NUM_ESPECIALIDADES; e++)
                {
                    dgvEvaluacion.Rows[fila].Cells[e + 1].Value =
                        datosIniciales[t, e].ToString("0.0", CultureInfo.InvariantCulture);
                }
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            double[,] notas = new double[NUM_TURNOS, NUM_ESPECIALIDADES];

            for (int t = 0; t < NUM_TURNOS; t++)
            {
                for (int j = 0; j < NUM_ESPECIALIDADES; j++)
                {
                    object valor = dgvEvaluacion.Rows[t].Cells[j + 1].Value;
                    string texto = valor == null ? "" : valor.ToString().Replace(',', '.');
                    double nota;

                    if (!double.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out nota)
                        || nota < 1 || nota > 5)
                    {
                        MessageBox.Show("Nota inválida en Turno " + (t + 1) + " / " + especialidades[j] +
                                        ". Debe estar entre 1 y 5.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvEvaluacion.CurrentCell = dgvEvaluacion.Rows[t].Cells[j + 1];
                        return;
                    }

                    notas[t, j] = nota;
                }
            }

            // Turno donde TODAS las evaluaciones son >= 4.0
            List<string> turnosOk = new List<string>();

            for (int t = 0; t < NUM_TURNOS; t++)
            {
                bool todasAltas = true;

                for (int j = 0; j < NUM_ESPECIALIDADES; j++)
                {
                    if (notas[t, j] < NOTA_MINIMA_TURNO)
                    {
                        todasAltas = false;
                        break;
                    }
                }

                if (todasAltas) turnosOk.Add("Turno " + (t + 1));
            }

            lblTurnoNotasAltas.Text = "Turno con todas las evaluaciones >= 4.0: " +
                (turnosOk.Count > 0 ? string.Join(", ", turnosOk.ToArray()) : "Ninguno");

            // Mejor nota (y en qué especialidad y turno)
            double mejor = notas[0, 0];
            for (int t = 0; t < NUM_TURNOS; t++)
            {
                for (int j = 0; j < NUM_ESPECIALIDADES; j++)
                {
                    if (notas[t, j] > mejor) mejor = notas[t, j];
                }
            }

            List<string> mejores = new List<string>();
            for (int t = 0; t < NUM_TURNOS; t++)
            {
                for (int j = 0; j < NUM_ESPECIALIDADES; j++)
                {
                    if (notas[t, j] == mejor)
                        mejores.Add(especialidades[j] + " (Turno " + (t + 1) + ")");
                }
            }

            lblMejorEspecialidad.Text = "Especialidad con mejor nota: " +
                string.Join(" / ", mejores.ToArray()) + " - " + mejor.ToString("0.0");

            // Promedio general de todas las evaluaciones
            double sumaTotal = 0;
            for (int t = 0; t < NUM_TURNOS; t++)
            {
                for (int j = 0; j < NUM_ESPECIALIDADES; j++)
                {
                    sumaTotal += notas[t, j];
                }
            }

            lblPromedioGeneral.Text = "Promedio general: " +
                (sumaTotal / (NUM_TURNOS * NUM_ESPECIALIDADES)).ToString("F2");

            // Promedio por especialidad
            dgvPromedioEspecialidad.Rows.Clear();

            for (int j = 0; j < NUM_ESPECIALIDADES; j++)
            {
                double suma = 0;
                for (int t = 0; t < NUM_TURNOS; t++)
                {
                    suma += notas[t, j];
                }

                dgvPromedioEspecialidad.Rows.Add(especialidades[j], (suma / NUM_TURNOS).ToString("F2"));
            }
        }
    }
}

