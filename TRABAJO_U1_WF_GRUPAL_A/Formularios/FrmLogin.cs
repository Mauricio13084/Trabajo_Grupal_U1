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
    public partial class FrmLogin : Form
    {
        int intentos = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;

            try
            {
                if (txtUsuario.Text == "admin" && txtContrasena.Text == "admin")
                {
                    MessageBox.Show("¡Bienvenido al Sistema!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MDIPrincipal principal = new MDIPrincipal();
                    principal.UsuarioLogueado = txtUsuario.Text;
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    intentos++;
                    int intentosRestantes = 3 - intentos;

                    if (intentos >= 3)
                    {
                        MessageBox.Show("Has alcanzado el limite de 3 intentos permitidos.", "Acceso Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show($"Usuario o contraseña incorrectos.\nTe quedan {intentosRestantes} intento(s).", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnIngresar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIngresar.Enabled = true;
            }
        }
    }
}
