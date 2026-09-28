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
    public partial class FrmEjercicio9 : Form
    {
        private const int TOTAL_ESTUDIANTES = 5;

        // Arreglos paralelos: una posición por estudiante
        private readonly double[] practicas = new double[TOTAL_ESTUDIANTES];
        private readonly double[] trabajos = new double[TOTAL_ESTUDIANTES];
        private readonly double[] examenes = new double[TOTAL_ESTUDIANTES];
        private readonly double[] notasFinales = new double[TOTAL_ESTUDIANTES];

        private int cantidad = 0;
        public FrmEjercicio9()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double practica, trabajo, examen;

            if (!LeerNota(btnPractica, "Práctica", out practica)) return;
            if (!LeerNota(btnTrabajos, "Trabajos", out trabajo)) return;
            if (!LeerNota(btnExamen, "Examen", out examen)) return;

            // Nota final: 30% + 30% + 40%
            double final = practica * 0.30 + trabajo * 0.30 + examen * 0.40;

            practicas[cantidad] = practica;
            trabajos[cantidad] = trabajo;
            examenes[cantidad] = examen;
            notasFinales[cantidad] = Math.Round(final, 2);
            cantidad++;

            MostrarTabla();

            btnPractica.Clear();
            btnTrabajos.Clear();
            btnExamen.Clear();
            btnPractica.Focus();

            if (cantidad == TOTAL_ESTUDIANTES)
            {
                DialogResult r = MessageBox.Show(
                    "Ya se registraron los 5 estudiantes.\n¿Desea empezar un nuevo grupo?",
                    "Registro completo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    cantidad = 0;
                    dgvEvaluaciones.Rows.Clear();
                }
                else
                {
                    btnCalcular.Enabled = false;
                }
            }
        }


        // Recorre los estudiantes registrados usando WHILE
        private void MostrarTabla()
        {
            dgvEvaluaciones.Rows.Clear();

            int i = 0;
            while (i < cantidad)
            {
                dgvEvaluaciones.Rows.Add(
                    "Estudiante " + (i + 1),
                    practicas[i].ToString("F2"),
                    trabajos[i].ToString("F2"),
                    examenes[i].ToString("F2"),
                    notasFinales[i].ToString("F2"),
                    ObtenerEstado(notasFinales[i]));
                i++;
            }
        }

        private string ObtenerEstado(double nota)
        {
            if (nota > 10 && nota <= 20) return "Aprobado";
            if (nota > 2 && nota <= 10) return "Desaprobado";
            return "Abandono";
        }

        // Valida que el TextBox tenga un número entre 0 y 20
        private bool LeerNota(TextBox caja, string campo, out double nota)
        {
            string texto = caja.Text.Trim().Replace(',', '.');

            if (!double.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out nota))
            {
                MessageBox.Show("Ingrese un número válido en " + campo + ".", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                caja.Focus();
                return false;
            }

            if (nota < 0 || nota > 20)
            {
                MessageBox.Show("La nota de " + campo + " debe estar entre 0 y 20.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                caja.Focus();
                return false;
            }

            return true;
        }
    }

}
