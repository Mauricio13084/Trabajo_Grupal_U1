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
        public FrmEjercicio2()
        {
            InitializeComponent();
        }

        private void FrmEjercicio2_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                cmbGenerar.Items.Add(i);
            }
            cmbGenerar.SelectedIndex = 19;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumero.Text, out int numeroBase))
                {
                    MessageBox.Show("Por favor, ingrese un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Focus();
                    return;
                }
                if (cmbGenerar.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione hasta qué número desea generar la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int limite = Convert.ToInt32(cmbGenerar.SelectedItem);

                dataGridView1.Rows.Clear();

                int cantidadPares = 0;
                int cantidadImpares = 0;
                int sumaResultados = 0;
                int mayorResultado = int.MinValue;
                int contadorMultiplos3 = 0;

                string paresList = "";
                string imparesList = "";

                for (int i = 1; i <= limite; i++)
                {
                    int resultado = numeroBase * i;
                    string operacion = $"{numeroBase} x {i}";

                    // Determinar si es par o impar
                    string parImpar = (resultado % 2 == 0) ? "Par" : "Impar";
                    if (resultado % 2 == 0)
                    {
                        cantidadPares++;
                        paresList += resultado + ", ";
                    }
                    else
                    {
                        cantidadImpares++;
                        imparesList += resultado + ", ";
                    }

                    // Determinar si es multiplo de 3
                    string esMultiplo3 = (resultado % 3 == 0) ? "Si" : "No";
                    if (resultado % 3 == 0)
                    {
                        contadorMultiplos3++;
                    }

                    // Encontrar el resultado mayor
                    if (resultado > mayorResultado)
                    {
                        mayorResultado = resultado;
                    }

                    // Sumar al total
                    sumaResultados += resultado;

                    // Agregar fila al DataGridView
                    dataGridView1.Rows.Add(operacion, resultado, parImpar, esMultiplo3);
                }

                label4.Text = $"{cantidadPares}";
                label6.Text = $"{cantidadImpares}";
                label8.Text = sumaResultados.ToString();
                label10.Text = mayorResultado.ToString();
                label12.Text = $"{contadorMultiplos3} resultados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            dataGridView1.Rows.Clear();
            if (cmbGenerar.Items.Count > 0)
                cmbGenerar.SelectedIndex = 19;

            label4.Text = "label4";
            label6.Text = "label6";
            label8.Text = "label8";
            label10.Text = "label10";
            label12.Text = "label12";

            txtNumero.Focus();
        }
    }
}
