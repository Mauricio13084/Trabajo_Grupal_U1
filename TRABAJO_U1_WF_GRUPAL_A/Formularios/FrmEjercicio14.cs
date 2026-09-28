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
    public partial class FrmEjercicio14 : Form
    {
        public FrmEjercicio14()
        {
            InitializeComponent();
        }

        private void FrmEjercicio14_Load(object sender, EventArgs e)
        {
            // Configurar los TextBox de resultado
            txtEstadoCivil.ReadOnly = true;
            txtEdad.ReadOnly = true;
            txtSexo.ReadOnly = true;
            txtResumen.ReadOnly = true;

            txtEstadoCivil.TextAlign = HorizontalAlignment.Center;
            txtEdad.TextAlign = HorizontalAlignment.Center;
            txtSexo.TextAlign = HorizontalAlignment.Center;
            txtResumen.TextAlign = HorizontalAlignment.Center;

            // Mensaje inicial
            txtResumen.Text = "Ingrese un código de 4 cifras y presione Analizar...";
            txtResumen.ForeColor = Color.Gray;

            // Forzar que los TextBox acepten cambios de color
            txtEstadoCivil.ReadOnly = false;
            txtEdad.ReadOnly = false;
            txtSexo.ReadOnly = false;
            txtResumen.ReadOnly = false;

           
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            // 1. VALIDACIÓN: Campo vacío
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, ingrese un código de 4 cifras.", "Campo vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            // 2. VALIDACIÓN: Debe ser un número entero de exactamente 4 cifras
            if (!int.TryParse(txtCodigo.Text, out int codigo) || txtCodigo.Text.Length != 4)
            {
                MessageBox.Show("El código debe ser un número entero de exactamente 4 cifras (Ej: 1231).",
                    "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }

            // 3. EXTRAER CADA DÍGITO DEL CÓDIGO
            // Formato: [EstadoCivil][DecenaEdad][UnidadEdad][Sexo]
            // Ejemplo: 1231 -> 1 | 2 | 3 | 1
            int primerDigito = codigo / 1000;              // Estado civil (1-4)
            int segundaCifra = (codigo / 100) % 10;        // Decena de la edad
            int terceraCifra = (codigo / 10) % 10;         // Unidad de la edad
            int cuartaCifra = codigo % 10;                 // Sexo (1 o 2)

            int edad = (segundaCifra * 10) + terceraCifra; // Ej: 2 y 3 -> 23 años

            // 4. VALIDAR QUE EL ESTADO CIVIL ESTÉ ENTRE 1 Y 4
            if (primerDigito < 1 || primerDigito > 4)
            {
                MessageBox.Show("El primer dígito (estado civil) debe estar entre 1 y 4.",
                    "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
                txtCodigo.Focus();
                return;
            }

            // 5. VALIDAR QUE EL SEXO SEA 1 O 2
            if (cuartaCifra != 1 && cuartaCifra != 2)
            {
                MessageBox.Show("El último dígito (sexo) debe ser 1 (Femenino) o 2 (Masculino).",
                    "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
                txtCodigo.Focus();
                return;
            }

            // 6. DECODIFICAR ESTADO CIVIL
            string estadoCivil = "";
            switch (primerDigito)
            {
                case 1: estadoCivil = "SOLTERO(A)"; break;
                case 2: estadoCivil = "CASADO(A)"; break;
                case 3: estadoCivil = "VIUDO(A)"; break;
                case 4: estadoCivil = "DIVORCIADO(A)"; break;
            }

            // 7. DECODIFICAR SEXO
            string sexo = (cuartaCifra == 1) ? "FEMENINO" : "MASCULINO";

            // 8. MOSTRAR RESULTADOS
            txtEstadoCivil.Text = estadoCivil;
            txtEdad.Text = edad + " años";
            txtSexo.Text = sexo;

            // Colores MORADOS
            txtEstadoCivil.ForeColor = Color.Purple;
            txtEdad.ForeColor = Color.Purple;
            txtSexo.ForeColor = Color.Purple;

            // 9. MOSTRAR RESUMEN
            txtResumen.Text = $"Código: {codigo}  |  {estadoCivil}  |  {edad} años  |  {sexo}";
            txtResumen.ForeColor = Color.Purple;

            // FORZAR REPINTADO
            txtEstadoCivil.Refresh();
            txtEdad.Refresh();
            txtSexo.Refresh();
            txtResumen.Refresh();
        }

        // Método auxiliar para limpiar todo
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtEstadoCivil.Clear();
            txtEdad.Clear();
            txtSexo.Clear();
            txtResumen.Text = "Ingrese un código de 4 cifras y presione Analizar...";
            txtResumen.ForeColor = Color.Gray;
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtCodigo.Focus();
        }

        private void txtCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Vuelve al MDI principal vacío
        }

        // Evento para que solo se puedan escribir números en el TextBox
       

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea letras y símbolos
            }
        }
    }
}
