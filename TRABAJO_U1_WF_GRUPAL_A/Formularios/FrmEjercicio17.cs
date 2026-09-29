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
        private int cantidadViajes = 0;
        private double totalRecaudado = 0;
        private double viajeMayor = 0;
        private double viajeMenor = double.MaxValue;
        private bool continuarViaje = false;

        private bool hayViajeCalculado = false;

        public FrmEjercicio17()
        {
            InitializeComponent();
        }

        private void FrmEjercicio17_Load(object sender, EventArgs e)
        {

            nudHora.Minimum = 0;
            nudHora.Maximum = 23;
            nudHora.Value = 0;


            txtFranja.ReadOnly = true;
            txtCosto.ReadOnly = true;
            txtMayor.ReadOnly = true;
            txtMenor.ReadOnly = true;
            txtViajes.ReadOnly = true;
            txtTotal.ReadOnly = true;

            txtFranja.TextAlign = HorizontalAlignment.Center;
            txtCosto.TextAlign = HorizontalAlignment.Center;
            txtMayor.TextAlign = HorizontalAlignment.Center;
            txtMenor.TextAlign = HorizontalAlignment.Center;
            txtViajes.TextAlign = HorizontalAlignment.Center;
            txtTotal.TextAlign = HorizontalAlignment.Center;

            txtFranja.Text = "—";
            txtCosto.Text = "—";
            txtMayor.Text = "S/ 0.00";
            txtMenor.Text = "S/ 0.00";
            txtViajes.Text = "0";
            txtTotal.Text = "S/ 0.00";

            rbEconomico.Checked = true;

            btnSi.Enabled = false;
            btnNo.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                int hora = (int)nudHora.Value;

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

                if (!rbEconomico.Checked && !rbConfort.Checked && !rbPremium.Checked)
                {
                    MessageBox.Show("Seleccione un tipo de vehículo.",
                        "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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


                double recargo = 0;
                if (rbConfort.Checked) recargo = 0.20;
                else if (rbPremium.Checked) recargo = 0.40;


                double costo = km * tarifaBase * (1 + recargo);


                txtFranja.Text = franja;
                txtCosto.Text = "S/ " + costo.ToString("F2");

                cantidadViajes++;
                totalRecaudado += costo;

                if (costo > viajeMayor) viajeMayor = costo;
                if (costo < viajeMenor) viajeMenor = costo;

                txtViajes.Text = cantidadViajes.ToString();
                txtTotal.Text = "S/ " + totalRecaudado.ToString("F2");
                txtMayor.Text = "S/ " + viajeMayor.ToString("F2");
                txtMenor.Text = "S/ " + viajeMenor.ToString("F2");

                hayViajeCalculado = true;
                btnSi.Enabled = true;
                btnNo.Enabled = true;

                btnCalcular.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            continuarViaje = true;

            txtKilometros.Clear();
            nudHora.Value = 0;
            rbEconomico.Checked = true;
            txtFranja.Text = "—";
            txtCosto.Text = "—";
            btnSi.Enabled = false;
            btnNo.Enabled = false;

            btnCalcular.Enabled = true;

            txtKilometros.Focus();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

            continuarViaje = false;
            btnSi.Enabled = false;
            btnNo.Enabled = false;

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtKilometros.Clear();
            nudHora.Value = 0;
            rbEconomico.Checked = true;
            txtFranja.Text = "—";
            txtCosto.Text = "—";
            txtKilometros.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
