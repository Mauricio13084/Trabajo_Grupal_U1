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
    public partial class FrmEjercicio17 : Form
    {
        // ===== VARIABLES ACUMULADORAS (persisten durante la sesión) =====
        private int cantidadViajes = 0;
        private double totalRecaudado = 0;
        private double viajeMayor = 0;
        private double viajeMenor = double.MaxValue;

        // Bandera que controla el bucle do-while
        private bool continuarViaje = false;

        // Bandera que indica si ya se calculó al menos un viaje
        private bool hayViajeCalculado = false;

        public FrmEjercicio17()
        {
            InitializeComponent();
        }

        private void FrmEjercicio17_Load(object sender, EventArgs e)
        {
            // Configurar NumericUpDown
            nudHora.Minimum = 0;
            nudHora.Maximum = 23;
            nudHora.Value = 0;

            // Configurar TextBox de resultados como solo lectura
            txtFranja.ReadOnly = true;
            txtCosto.ReadOnly = true;
            txtMayor.ReadOnly = true;
            txtMenor.ReadOnly = true;
            txtViajes.ReadOnly = true;
            txtTotal.ReadOnly = true;

            // Centrar el texto
            txtFranja.TextAlign = HorizontalAlignment.Center;
            txtCosto.TextAlign = HorizontalAlignment.Center;
            txtMayor.TextAlign = HorizontalAlignment.Center;
            txtMenor.TextAlign = HorizontalAlignment.Center;
            txtViajes.TextAlign = HorizontalAlignment.Center;
            txtTotal.TextAlign = HorizontalAlignment.Center;

            // Inicializar valores
            txtFranja.Text = "—";
            txtCosto.Text = "—";
            txtMayor.Text = "S/ 0.00";
            txtMenor.Text = "S/ 0.00";
            txtViajes.Text = "0";
            txtTotal.Text = "S/ 0.00";

            // RadioButton por defecto
            rbEconomico.Checked = true;

            // Los botones SÍ / NO empiezan deshabilitados
            btnSi.Enabled = false;
            btnNo.Enabled = false;
        }

        // ===== EVENTO DEL BOTÓN CALCULAR VIAJE =====
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. VALIDAR HORA
                int hora = (int)nudHora.Value;

                // 2. VALIDAR KILÓMETROS
                if (string.IsNullOrWhiteSpace(txtKilometros.Text))
                {
                    MessageBox.Show("Ingrese los kilómetros recorridos.",
                        "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKilometros.Focus();
                    return;
                }

                if (!double.TryParse(txtKilometros.Text, out double km) || km <= 0)
                {
                    MessageBox.Show("Los kilómetros deben ser un número mayor a 0.",
                        "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKilometros.Clear();
                    txtKilometros.Focus();
                    return;
                }

                // 3. VALIDAR TIPO DE VEHÍCULO
                if (!rbEconomico.Checked && !rbConfort.Checked && !rbPremium.Checked)
                {
                    MessageBox.Show("Seleccione un tipo de vehículo.",
                        "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4. DETERMINAR FRANJA HORARIA Y TARIFA BASE (switch)
                string franja = "";
                double tarifaBase = 0;

                switch (hora)
                {
                    case int h when (h >= 0 && h <= 5):
                        franja = "MADRUGADA";
                        tarifaBase = 1.50;
                        break;
                    case int h when (h >= 6 && h <= 17):
                        franja = "DIURNO";
                        tarifaBase = 2.00;
                        break;
                    case int h when (h >= 18 && h <= 23):
                        franja = "NOCTURNO";
                        tarifaBase = 2.50;
                        break;
                }

                // 5. RECARGO POR TIPO DE VEHÍCULO
                double recargo = 0;
                if (rbConfort.Checked) recargo = 0.20;
                else if (rbPremium.Checked) recargo = 0.40;

                // 6. CALCULAR COSTO DEL VIAJE
                double costo = km * tarifaBase * (1 + recargo);

                // 7. MOSTRAR RESULTADOS DEL VIAJE ACTUAL
                txtFranja.Text = franja;
                txtCosto.Text = "S/ " + costo.ToString("F2");

                // 8. ACUMULAR DATOS (comparando contra el acumulado, sin listas)
                cantidadViajes++;
                totalRecaudado += costo;

                if (costo > viajeMayor) viajeMayor = costo;
                if (costo < viajeMenor) viajeMenor = costo;

                // 9. ACTUALIZAR ACUMULADOS VISUALES
                txtViajes.Text = cantidadViajes.ToString();
                txtTotal.Text = "S/ " + totalRecaudado.ToString("F2");
                txtMayor.Text = "S/ " + viajeMayor.ToString("F2");
                txtMenor.Text = "S/ " + viajeMenor.ToString("F2");

                // 10. HABILITAR BOTONES SÍ / NO PARA LA PREGUNTA
                hayViajeCalculado = true;
                btnSi.Enabled = true;
                btnNo.Enabled = true;

                // 11. BLOQUEAR EL BOTÓN CALCULAR HASTA QUE RESPONDA
                btnCalcular.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== EVENTO DEL BOTÓN SÍ (continuar con otro viaje) =====
        private void btnSi_Click(object sender, EventArgs e)
        {
            // El usuario quiere otro viaje: limpiar campos y reactivar
            continuarViaje = true;

            // Limpiar solo los campos del viaje actual
            txtKilometros.Clear();
            nudHora.Value = 0;
            rbEconomico.Checked = true;
            txtFranja.Text = "—";
            txtCosto.Text = "—";

            // Deshabilitar los botones SÍ / NO hasta que se calcule otro viaje
            btnSi.Enabled = false;
            btnNo.Enabled = false;

            // Reactivar el botón CALCULAR
            btnCalcular.Enabled = true;

            // Enfocar el campo de kilómetros
            txtKilometros.Focus();
        }

        // ===== EVENTO DEL BOTÓN NO (terminar la sesión) =====
        private void btnNo_Click(object sender, EventArgs e)
        {
            // El usuario no quiere más viajes: salir del bucle y mostrar resumen
            continuarViaje = false;

            // Deshabilitar los botones SÍ / NO
            btnSi.Enabled = false;
            btnNo.Enabled = false;

            // Mostrar resumen final
            if (cantidadViajes > 0)
            {
                MessageBox.Show(
                    $"Resumen de la sesión:\n\n" +
                    $"Viajes realizados: {cantidadViajes}\n" +
                    $"Total recaudado: S/ {totalRecaudado:F2}\n" +
                    $"Viaje mayor: S/ {viajeMayor:F2}\n" +
                    $"Viaje menor: S/ {viajeMenor:F2}",
                    "Resumen Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se realizaron viajes en esta sesión.",
                    "Sin viajes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ===== EVENTO DEL BOTÓN LIMPIAR =====
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtKilometros.Clear();
            nudHora.Value = 0;
            rbEconomico.Checked = true;
            txtFranja.Text = "—";
            txtCosto.Text = "—";
            txtKilometros.Focus();
        }

        // ===== EVENTO DEL BOTÓN CERRAR =====
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
