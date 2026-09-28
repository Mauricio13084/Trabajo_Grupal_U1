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
    public partial class FrmEjercicio11 : Form
    {
        private const string VOCALES = "aeiouáéíóúü";

        // null = todavía no se evaluó; true = par; false = impar
        private bool? esPar = null;
        public FrmEjercicio11()
        {
            InitializeComponent();
            // Al inicio, la zona de "Accion" está bloqueada hasta evaluar la palabra inicial
            BloquearAccion();
        }


        //Contar vocales de la palabra inicial
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabraInicial.Text.Trim();

            if (!EsPalabraValida(palabra))
            {
                MessageBox.Show("Ingrese una sola palabra (solo letras, sin espacios).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPalabraInicial.Focus();
                return;
            }

            int vocales = ContarVocales(palabra);
            esPar = (vocales % 2 == 0);

            lblResultadoVocales.Text = "Vocales: " + vocales + (esPar.Value ? " (PAR)" : " (IMPAR)");
            lblResultadoFinal.Text = "Resultado final:";

            // Habilitar solo la caja que corresponde
            txtFrase.Enabled = esPar.Value;
            txtPalabra.Enabled = !esPar.Value;
            btnAnalizar.Enabled = true;

            if (esPar.Value) txtFrase.Focus();
            else txtPalabra.Focus();
        }

        //Analizar segun sea PAR o IMPAR
        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            if (esPar == null) return;

            if (esPar.Value)
            {
                // PAR: convertir la frase a mayúsculas
                string frase = txtFrase.Text.Trim();

                if (frase == "")
                {
                    MessageBox.Show("Ingrese una frase.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFrase.Focus();
                    return;
                }

                lblResultadoFinal.Text = "Resultado final: " + frase.ToUpper();
            }
            else
            {
                // IMPAR: hallar la longitud de la palabra
                string palabra = txtPalabra.Text.Trim();

                if (!EsPalabraValida(palabra))
                {
                    MessageBox.Show("Ingrese una sola palabra (solo letras, sin espacios).", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPalabra.Focus();
                    return;
                }

                lblResultadoFinal.Text = "Resultado final: la palabra \"" + palabra +
                                         "\" tiene " + palabra.Length + " letras";
            }

            txtPalabraInicial.Clear();
            BloquearAccion();
            txtPalabraInicial.Focus();
        }

        //METODOS AUXILIARES
        private void BloquearAccion()
        {
            esPar = null;
            txtFrase.Clear();
            txtPalabra.Clear();
            txtFrase.Enabled = false;
            txtPalabra.Enabled = false;
            btnAnalizar.Enabled = false;
        }

        private int ContarVocales(string palabra)
        {
            int contador = 0;
            string minus = palabra.ToLower();

            for (int i = 0; i < minus.Length; i++)
            {
                if (VOCALES.IndexOf(minus[i]) >= 0) contador++;
            }
            return contador;
        }

        private bool EsPalabraValida(string palabra)
        {
            if (palabra == "") return false;

            foreach (char c in palabra)
            {
                if (!char.IsLetter(c)) return false;
            }
            return true;
        }
    }
}

