using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRABAJO_U1_WF_GRUPAL_A.Clases;

namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    public partial class FrmEjercicio7 : Form
    {
        // Lista en memoria donde se guardan los contactos
        private readonly List<ClsContacto> contactos = new List<ClsContacto>();

      
        private string filtroActual = "";
        public FrmEjercicio7()
        {
            InitializeComponent();

            // Configuración
            dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContactos.MultiSelect = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre del contacto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (!TelefonoValido(telefono))
            {
                MessageBox.Show("El teléfono debe tener solo dígitos (entre 6 y 9).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }

            if (!EmailValido(email))
            {
                MessageBox.Show("Ingrese un correo válido (ejemplo: nombre@correo.com).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            contactos.Add(new ClsContacto(nombre, telefono, email));

            // Limpiar campos y mostrar todos los contactos
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtBuscarNombre.Clear();
            filtroActual = "";
            MostrarContactos();
            txtNombre.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtroActual = txtBuscarNombre.Text.Trim();
            MostrarContactos();

            if (filtroActual != "" && dgvContactos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron contactos con ese nombre.", "Búsqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un contacto de la lista para eliminarlo.", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClsContacto seleccionado = dgvContactos.SelectedRows[0].Tag as ClsContacto;
            if (seleccionado == null) return;

            DialogResult r = MessageBox.Show(
                "¿Eliminar a " + seleccionado.Nombre + "?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                contactos.Remove(seleccionado);
                MostrarContactos();
            }
        }


        // METODOS
        private void MostrarContactos()
        {
            dgvContactos.Rows.Clear();

            foreach (ClsContacto c in contactos)
            {
                bool coincide = filtroActual == "" ||
                    c.Nombre.IndexOf(filtroActual, StringComparison.OrdinalIgnoreCase) >= 0;

                if (coincide)
                {
                    int fila = dgvContactos.Rows.Add(c.Nombre, c.Telefono, c.Email);
                    dgvContactos.Rows[fila].Tag = c; // guardamos el objeto para poder eliminarlo
                }
            }
        }

        private bool TelefonoValido(string telefono)
        {
            if (telefono.Length < 6 || telefono.Length > 9) return false;

            foreach (char c in telefono)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }

        private bool EmailValido(string email)
        {
            if (email == "") return false;
            try
            {
                MailAddress m = new MailAddress(email);
                return m.Address == email;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // Solo permite dígitos en el teléfono
        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
