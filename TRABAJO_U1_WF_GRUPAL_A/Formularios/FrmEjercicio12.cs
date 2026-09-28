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
    public partial class FrmEjercicio12 : Form
    {
        public FrmEjercicio12()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            int contFizz = 0;       // solo múltiplos de 3
            int contBuzz = 0;       // solo múltiplos de 5
            int contFizzBuzz = 0;   // múltiplos de 3 y 5 a la vez
            int contNumeros = 0;    // números sin cambios

            lstResultados.BeginUpdate();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    lstResultados.Items.Add("fizzbuzz");
                    contFizzBuzz++;
                }
                else if (i % 3 == 0)
                {
                    lstResultados.Items.Add("fizz");
                    contFizz++;
                }
                else if (i % 5 == 0)
                {
                    lstResultados.Items.Add("buzz");
                    contBuzz++;
                }
                else
                {
                    lstResultados.Items.Add(i.ToString());
                    contNumeros++;
                }
            }

            lstResultados.EndUpdate();

            lblCountFizz.Text = "Multiplos de 3: " + contFizz;
            lblCountBuzz.Text = "Multiplos de 5: " + contBuzz;
            lblCountFizzBuzz.Text = "Multiplos de 3 y 5: " + contFizzBuzz;
            lblCountNumeros.Text = "Numeros sin cambios: " + contNumeros;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            lblCountFizz.Text = "Multiplos de 3:";
            lblCountBuzz.Text = "Multiplos de 5:";
            lblCountFizzBuzz.Text = "Multiplos de 3 y 5:";
            lblCountNumeros.Text = "Numeros sin cambios:";
        }
    }
}
