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
    public partial class FrmEjercicio8 : Form
    {
        private const int NUM_CURSOS = 5;
        private const double NOTA_APROBAR = 11;

        private readonly Random rnd = new Random();

        // Lista de nombres inventados para los estudiantes
        private readonly string[] nombresEstudiantes =
        {
            "Ana Torres",
            "Luis Mendoza",
            "Carlos Quispe",
            "María Flores",
            "Jorge Mamani",
            "Lucía Vargas",
            "Pedro Sánchez",
            "Daniela Rojas",
            "Miguel Condori",
            "Sofía Ramos",
            "Diego Castillo",
            "Valeria Pérez",
            "Andrés Huamán",
            "Camila García",
            "Fernando López",
            "Gabriela Cruz",
            "José Fernández",
            "Paola Medina",
            "Ricardo Salazar",
            "Andrea Morales",
            "Juan Pérez",
            "Carla Mendoza",
            "Marco Salas",
            "Elena Flores",
            "Roberto Vargas",
            "Natalia Quispe",
            "Sebastián Rojas",
            "Diana Mamani",
            "Álvaro Torres",
            "Patricia Sánchez",
            "Renato Castillo",
            "Melissa Condori",
            "Bruno Ramos",
            "Alejandra Medina",
            "Cristian López",
            "Fernanda García",
            "Héctor Cruz",
            "Mónica Huamán",
            "Raúl Salazar",
            "Claudia Morales",
            "Kevin Flores",
            "Vanessa Pérez",
            "Oscar Mendoza",
            "Silvia Torres",
            "Eduardo Quispe",
            "Rosa Vargas",
            "Martín Mamani",
            "Laura Rojas",
            "Pablo Sánchez",
            "Nicole Castillo"
        };
        public FrmEjercicio8()
        {
            InitializeComponent();
            // Configuración del TextBox
            txtCantidad.Text = "";

            // Configuración del DataGridView
            dgvNotas.ReadOnly = false;
            dgvNotas.AllowUserToAddRows = false;

            colEstudiante.ReadOnly = true;
            colPromedio.ReadOnly = true;

            colCurso1.ReadOnly = false;
            colCurso2.ReadOnly = false;
            colCurso3.ReadOnly = false;
            colCurso4.ReadOnly = false;
            colCurso5.ReadOnly = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int n;

            // Validar la cantidad de estudiantes
            if (!int.TryParse(txtCantidad.Text, out n))
            {
                MessageBox.Show(
                    "Ingrese una cantidad válida de estudiantes.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCantidad.Focus();
                return;
            }

            // Validar rango
            if (n < 1 || n > nombresEstudiantes.Length)
            {
                MessageBox.Show(
                    "La cantidad de estudiantes debe estar entre 1 y " +
                    nombresEstudiantes.Length + ".",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCantidad.Focus();
                return;
            }

            dgvNotas.Rows.Clear();
            dgvResumenCursos.Rows.Clear();

            // Generar estudiantes y sus notas
            for (int i = 0; i < n; i++)
            {
                int fila = dgvNotas.Rows.Add();

                // Nombre del estudiante
                dgvNotas.Rows[fila].Cells[0].Value =
                    nombresEstudiantes[i];

                // Notas de los 5 cursos
                for (int j = 0; j < NUM_CURSOS; j++)
                {
                    dgvNotas.Rows[fila].Cells[j + 1].Value =
                        rnd.Next(0, 21); // 0 a 20
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n = dgvNotas.Rows.Count;

            if (n == 0)
            {
                MessageBox.Show(
                    "Primero presione Generar para crear la matriz de notas.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Matriz A de N x 5
            double[,] A = new double[n, NUM_CURSOS];

            // Leer las notas del DataGridView
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < NUM_CURSOS; j++)
                {
                    object valor =
                        dgvNotas.Rows[i].Cells[j + 1].Value;

                    string texto =
                        valor == null
                        ? ""
                        : valor.ToString().Replace(',', '.');

                    double nota;

                    bool ok =
                        double.TryParse(
                            texto,
                            NumberStyles.Float,
                            CultureInfo.InvariantCulture,
                            out nota)
                        && nota >= 0
                        && nota <= 20;

                    if (ok)
                    {
                        A[i, j] = nota;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Nota inválida en la fila " + (i + 1) +
                            ", curso C" + (j + 1) +
                            ". Debe estar entre 0 y 20.",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        dgvNotas.CurrentCell =
                            dgvNotas.Rows[i].Cells[j + 1];

                        return;
                    }
                }
            }


            // a) Nota promedio de cada estudiante

            for (int i = 0; i < n; i++)
            {
                double suma = 0;

                for (int j = 0; j < NUM_CURSOS; j++)
                {
                    suma += A[i, j];
                }

                double promedio = suma / NUM_CURSOS;

                dgvNotas.Rows[i].Cells[NUM_CURSOS + 1].Value =
                    promedio.ToString("F2");
            }

            // b), c) y d)
            // Promedio, aprobados y desaprobados por curso

            dgvResumenCursos.Rows.Clear();

            for (int j = 0; j < NUM_CURSOS; j++)
            {
                double suma = 0;
                int aprobados = 0;
                int desaprobados = 0;

                for (int i = 0; i < n; i++)
                {
                    suma += A[i, j];

                    if (A[i, j] >= NOTA_APROBAR)
                    {
                        aprobados++;
                    }
                    else
                    {
                        desaprobados++;
                    }
                }

                double promedioCurso = suma / n;

                dgvResumenCursos.Rows.Add(
                    "C" + (j + 1),
                    promedioCurso.ToString("F2"),
                    aprobados,
                    desaprobados);
            }
        }
    }
}

