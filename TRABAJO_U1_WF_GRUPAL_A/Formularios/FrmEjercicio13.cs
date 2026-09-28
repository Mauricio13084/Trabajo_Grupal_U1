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
    public partial class FrmEjercicio13 : Form
    {
        public FrmEjercicio13()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            // 1. VALIDACIÓN: Verificar que no esté vacío
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, ingrese un código de 3 cifras.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            // 2. VALIDACIÓN: Verificar que sea un número entero de 3 cifras
            if (!int.TryParse(txtCodigo.Text, out int codigo) || txtCodigo.Text.Length != 3)
            {
                MessageBox.Show("El código debe ser un número entero de exactamente 3 cifras (Ej: 102).", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }

            // 3. Limpiamos los CheckBox antes de evaluar
            chkAdministrativo.Checked = false;
            chkDirectivo.Checked = false;
            chkVendedor.Checked = false;
            chkSeguridad.Checked = false;

            // 4. APLICAMOS LA LÓGICA DEL EJERCICIO 13
            bool div2 = (codigo % 2 == 0);
            bool div3 = (codigo % 3 == 0);
            bool div5 = (codigo % 5 == 0);

            bool analizado = false; // Variable para saber si cayó en alguna categoría

            // Evaluamos los casos según el enunciado
            if (div2 && div3 && div5)
            {
                chkAdministrativo.Checked = true;
                analizado = true;
            }
            else if (div3 && div5 && !div2)
            {
                chkDirectivo.Checked = true;
                analizado = true;
            }
            else if (div2 && !div3 && !div5)
            {
                chkVendedor.Checked = true;
                analizado = true;
            }
            else if (!div2 && !div3 && !div5)
            {
                chkSeguridad.Checked = true;
                analizado = true;
            }

            // 5. Mostramos el resultado en el TextBox
            if (analizado)
            {
                txtResultado.Text = "ANALIZADO";
                txtResultado.ForeColor = Color.Green;
            }
            else
            {
                txtResultado.Text = "NO ANALIZADO";
                txtResultado.ForeColor = Color.Red;
            }

            // FORZAR REPINTADO
            txtResultado.Refresh();
            txtResultado.Update();
        }

        

        private void FrmEjercicio13_Load(object sender, EventArgs e)
        {
            // Configuramos el TextBox de resultado al iniciar
            txtResultado.Text = "";
            txtResultado.ReadOnly = true;
            txtResultado.TextAlign = HorizontalAlignment.Center;
            txtResultado.BackColor = Color.White;
            txtResultado.ForeColor = Color.Black; // Color inicial
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            txtCodigo.Clear();
            txtResultado.Clear(); // Borra el "ANALIZADO" o "NO ANALIZADO"

            // Desmarcar todos los CheckBox
            chkAdministrativo.Checked = false;
            chkDirectivo.Checked = false;
            chkVendedor.Checked = false;
            chkSeguridad.Checked = false;

            // Poner el cursor en el TextBox listo para escribir
            txtCodigo.Focus();
        }

        private void txtCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario hijo y vuelve al MDI principal vacío
        }
    }
}
