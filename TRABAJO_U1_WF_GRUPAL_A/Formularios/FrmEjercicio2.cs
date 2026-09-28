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
    public partial class FrmEjercicio2 : Form
    {
        private int contadorUsuariosRegistrados = 0;
        private int limiteUsuarios = 0;
        public FrmEjercicio2()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (contadorUsuariosRegistrados == 0)
                {
                    if (!int.TryParse(txtUsuario.Text, out limiteUsuarios) || limiteUsuarios <= 0)
                    {
                        MessageBox.Show("Ingrese una cantidad valida de usuarios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (contadorUsuariosRegistrados >= limiteUsuarios)
                {
                    MessageBox.Show($"Ya se registro el total de {limiteUsuarios} usuarios indicados. Presione 'Calcular'.", "Limite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!double.TryParse(txtConsumo.Text, out double consumo) || consumo < 0)
                {
                    MessageBox.Show("Por favor, ingrese un consumo en m3 valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                contadorUsuariosRegistrados++;
                string nombreUsuario = $"Usuario {contadorUsuariosRegistrados}";

                double montoPagar = 0;
                if (consumo <= 10)
                {
                    montoPagar = 15;
                }
                else if (consumo >= 11 && consumo <= 20)
                {
                    montoPagar = 25;
                }
                else if (consumo >= 21 && consumo <= 30)
                {
                    montoPagar = 40;
                }
                else
                {
                    double adicional = consumo - 30;
                    montoPagar = 40 + (adicional * 2);
                }

                dataGridView1.Rows.Add(nombreUsuario, consumo, montoPagar.ToString("F2"));

                txtConsumo.Clear();
                txtConsumo.Focus();

                txtUsuario.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay registros en la tabla para calcular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalRecaudado = 0;
            double sumaConsumo = 0;
            double mayorConsumo = -1;
            double menorConsumo = double.MaxValue;
            string usuarioMayor = "";
            string usuarioMenor = "";
            int contadorSuperan30 = 0;
            int totalFilas = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue;

                string usuario = fila.Cells[0].Value.ToString();
                double consumo = Convert.ToDouble(fila.Cells[1].Value);
                double monto = Convert.ToDouble(fila.Cells[2].Value);

                totalRecaudado += monto;
                sumaConsumo += consumo;
                totalFilas++;

                if (consumo > mayorConsumo)
                {
                    mayorConsumo = consumo;
                    usuarioMayor = usuario;
                }
                if (consumo < menorConsumo)
                {
                    menorConsumo = consumo;
                    usuarioMenor = usuario;
                }
                if (consumo > 30)
                {
                    contadorSuperan30++;
                }
            }

            double promedioConsumo = totalFilas > 0 ? sumaConsumo / totalFilas : 0;

            label4.Text = $"S/ {totalRecaudado:F2}";
            label6.Text = $"{usuarioMayor} ({mayorConsumo} m3)";
            label8.Text = $"{usuarioMenor} ({menorConsumo} m3)";
            label10.Text = $"{promedioConsumo:F2} m3";
            label12.Text = $"{contadorSuperan30} usuarios";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtUsuario.Clear();
            txtConsumo.Clear();
            txtUsuario.Enabled = true;
            contadorUsuariosRegistrados = 0;
            limiteUsuarios = 0;

            label4.Text = "label4";
            label6.Text = "label6";
            label8.Text = "label8";
            label10.Text = "label10";
            label12.Text = "label12";
        }
    }
}
