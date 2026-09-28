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
    public partial class FrmEjercicio6 : Form
    {
        // Saldo inicial de la cuenta
        private int saldo = 1000;

        // Denominaciones disponibles en el cajero
        private readonly int[] billetes = { 200, 100, 50, 20, 10 };
        public FrmEjercicio6()
        {
            InitializeComponent();
            // Mostrar el saldo inicial
            lblSaldoAnterior.Text = "Saldo anterior: S/ " + saldo.ToString("F2");
            lblMontoRetirado.Text = "Monto retirado: S/ 0.00";
            lblSaldoRestante.Text = "Saldo restante: S/ " + saldo.ToString("F2");

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un monto
            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show(
                    "Ingrese el monto que desea retirar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMonto.Focus();
                return;
            }

            int monto;

            // Validar que sea un número entero
            if (!int.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show(
                    "El monto debe ser un número entero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMonto.Focus();
                return;
            }

            // VALIDACIÓN 1: MONTO POSITIVO
            if (monto <= 0)
            {
                MessageBox.Show(
                    "El monto debe ser positivo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMonto.Focus();
                return;
            }

            // VALIDACIÓN 2: MÚLTIPLO DE 10
            if (monto % 10 != 0)
            {
                MessageBox.Show(
                    "El monto debe ser múltiplo de 10.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMonto.Focus();
                return;
            }

            // VALIDACIÓN 3: NO SUPERAR EL SALDO
            if (monto > saldo)
            {
                MessageBox.Show(
                    "El monto solicitado supera el saldo disponible.\n" +
                    "Saldo disponible: S/ " + saldo.ToString("F2"),
                    "Fondos insuficientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMonto.Focus();
                return;
            }

            // Guardamos el saldo antes del retiro
            int saldoAnterior = saldo;

            // Cantidad restante por entregar
            int restante = monto;

            // Cantidad total de billetes entregados
            int totalBilletes = 0;

            // Limpiar el DataGridView
            dgvDenominacion.Rows.Clear();

            // CALCULAR BILLETES
            // Se recorre el arreglo de denominaciones.
            // Se utiliza división para obtener la cantidad de
            // billetes de cada denominación.

            for (int i = 0; i < billetes.Length; i++)
            {
                int denominacion = billetes[i];

                int cantidad = restante / denominacion;

                // Actualizar el monto restante
                restante = restante % denominacion;

                // Acumular cantidad total de billetes
                totalBilletes += cantidad;

                // Mostrar la denominación y cantidad
                dgvDenominacion.Rows.Add(
                    "S/ " + denominacion,
                    cantidad);
            }

            // ACTUALIZAR SALDO

            saldo = saldo - monto;

            // MOSTRAR RESUMEN
            lblSaldoAnterior.Text =
                "Saldo anterior: S/ " + saldoAnterior.ToString("F2");

            lblMontoRetirado.Text =
                "Monto retirado: S/ " + monto.ToString("F2");

            lblSaldoRestante.Text =
                "Saldo restante: S/ " + saldo.ToString("F2");


            // MOSTRAR CANTIDAD TOTAL DE BILLETES

            MessageBox.Show(
                "Retiro realizado correctamente.\n\n" +
                "Monto retirado: S/ " + monto.ToString("F2") + "\n" +
                "Cantidad de billetes entregados: " + totalBilletes + "\n" +
                "Saldo restante: S/ " + saldo.ToString("F2"),
                "Operación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar el TextBox del monto
            txtMonto.Clear();
            txtMonto.Focus();
        }

        //BOTON LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Restaurar el saldo inicial
            saldo = 1000;

            // Limpiar los controles
            txtMonto.Clear();
            dgvDenominacion.Rows.Clear();

            // Restaurar los textos
            lblSaldoAnterior.Text =
                "Saldo anterior: S/ " + saldo.ToString("F2");

            lblMontoRetirado.Text =
                "Monto retirado: S/ 0.00";

            lblSaldoRestante.Text =
                "Saldo restante: S/ " + saldo.ToString("F2");

            txtMonto.Focus();
        }
    
    }
}
