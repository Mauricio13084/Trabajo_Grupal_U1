using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRABAJO_U1_WF_GRUPAL_A.Clases;

namespace TRABAJO_U1_WF_GRUPAL_A.Formularios
{
    public partial class FrmEjercicio16 : Form
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();

        public FrmEjercicio16()
        {
            InitializeComponent();
        }

        private void FrmEjercicio16_Load(object sender, EventArgs e)
        {
            // Cargar carreras en el ComboBox
            cmbCarrera.Items.Add("Ing. Sistemas");
            cmbCarrera.Items.Add("Ing. Electrónica");
            cmbCarrera.Items.Add("Ing. Civil");
            cmbCarrera.Items.Add("Ing. Ambiental");
            cmbCarrera.Items.Add("Ing. Industrial");
            cmbCarrera.Items.Add("Ing. Agroindustrial");
            cmbCarrera.SelectedIndex = 0;

            // Configurar ListView de errores
            lvErrores.View = View.Details;
            lvErrores.Columns.Add("Hora", 80);
            lvErrores.Columns.Add("Campo", 100);
            lvErrores.Columns.Add("Detalle", 200);
            lvErrores.FullRowSelect = true;

            // Configurar DataGridView
            dgvMatriculados.Columns.Clear();
            dgvMatriculados.Columns.Add("DNI", "DNI");
            dgvMatriculados.Columns.Add("Nombre", "Nombre");
            dgvMatriculados.Columns.Add("Edad", "Edad");
            dgvMatriculados.Columns.Add("Carrera", "Carrera");
            dgvMatriculados.Columns.Add("Turno", "Turno");
            dgvMatriculados.Columns.Add("Correo", "Correo");
            dgvMatriculados.AllowUserToAddRows = false;
            dgvMatriculados.ReadOnly = true;
            dgvMatriculados.RowHeadersVisible = false;

            // Inicializar TextBox de resultados
            txtSistemas.Text = "0";
            txtElectronica.Text = "0";
            txtCivil.Text = "0";
            txtAmbiental.Text = "0";
            txtIndustrial.Text = "0";
            txtAgroindustrial.Text = "0";
            txtTurnoManana.Text = "0";
            txtTurnoTarde.Text = "0";
            txtTurnoNoche.Text = "0";
            txtEdadPromedio.Text = "0";
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mtxtDNI.Text) || mtxtDNI.Text.Replace(" ", "").Trim().Length != 8)
                {
                    RegistrarError("DNI", "El DNI debe tener 8 dígitos.");
                    throw new Exception("El DNI debe tener exactamente 8 dígitos.");
                }
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    RegistrarError("Nombre", "El nombre no puede estar vacío.");
                    throw new Exception("El nombre no puede estar vacío.");
                }
                if (nudEdad.Value <= 16)
                {
                    RegistrarError("Edad", "La edad debe ser mayor a 16 años.");
                    throw new Exception("La edad debe ser mayor a 16 años.");
                }
                if (cmbCarrera.SelectedIndex == -1)
                {
                    RegistrarError("Carrera", "Debe seleccionar una carrera.");
                    throw new Exception("Debe seleccionar una carrera.");
                }
                if (!rbManana.Checked && !rbTarde.Checked && !rbNoche.Checked)
                {
                    RegistrarError("Turno", "Debe seleccionar un turno.");
                    throw new Exception("Debe seleccionar un turno (Mañana, Tarde o Noche).");
                }
                if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
                {
                    RegistrarError("Correo", "El correo debe contener '@' y no estar vacío.");
                    throw new Exception("El correo debe contener '@' y no estar vacío.");
                }

                string turno = rbManana.Checked ? "Mañana" : (rbTarde.Checked ? "Tarde" : "Noche");

                Estudiante nuevo = new Estudiante(
                    mtxtDNI.Text.Replace(" ", "").Trim(),
                    txtNombre.Text.Trim(),
                    (int)nudEdad.Value,
                    cmbCarrera.SelectedItem.ToString(),
                    turno,
                    txtCorreo.Text.Trim()
                );

                estudiantes.Add(nuevo);

                dgvMatriculados.Rows.Add(nuevo.DNI, nuevo.Nombre, nuevo.Edad,
                                         nuevo.Carrera, nuevo.Turno, nuevo.Correo);
                ActualizarCalculos();

                MessageBox.Show("¡Estudiante matriculado correctamente!",
                    "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RegistrarError(string campo, string detalle)
        {
            ListViewItem item = new ListViewItem(DateTime.Now.ToString("HH:mm:ss"));
            item.SubItems.Add(campo);
            item.SubItems.Add(detalle);
            item.ForeColor = Color.Red;
            lvErrores.Items.Add(item);
        }
        private void ActualizarCalculos()
        {
            if (estudiantes.Count == 0)
            {
                txtSistemas.Text = "0";
                txtElectronica.Text = "0";
                txtCivil.Text = "0";
                txtAmbiental.Text = "0";
                txtIndustrial.Text = "0";
                txtAgroindustrial.Text = "0";
                txtTurnoManana.Text = "0";
                txtTurnoTarde.Text = "0";
                txtTurnoNoche.Text = "0";
                txtEdadPromedio.Text = "0";
                return;
            }
            int sistemas = 0, electronica = 0, civil = 0, ambiental = 0, industrial = 0, agroindustrial = 0;
            int manana = 0, tarde = 0, noche = 0;
            double sumaEdades = 0;
            foreach (var est in estudiantes)
            {
                switch (est.Carrera)
                {
                    case "Ing. Sistemas": sistemas++; break;
                    case "Ing. Electrónica": electronica++; break;
                    case "Ing. Civil": civil++; break;
                    case "Ing. Ambiental": ambiental++; break;
                    case "Ing. Industrial": industrial++; break;
                    case "Ing. Agroindustrial": agroindustrial++; break;
                }

                if (est.Turno == "Mañana") manana++;
                else if (est.Turno == "Tarde") tarde++;
                else if (est.Turno == "Noche") noche++;

                sumaEdades += est.Edad;
            }
            txtSistemas.Text = sistemas.ToString();
            txtElectronica.Text = electronica.ToString();
            txtCivil.Text = civil.ToString();
            txtAmbiental.Text = ambiental.ToString();
            txtIndustrial.Text = industrial.ToString();
            txtAgroindustrial.Text = agroindustrial.ToString();

            txtTurnoManana.Text = manana.ToString();
            txtTurnoTarde.Text = tarde.ToString();
            txtTurnoNoche.Text = noche.ToString();
            double promedio = sumaEdades / estudiantes.Count;
            txtEdadPromedio.Text = promedio.ToString("F2");
        }
    
        private void LimpiarCampos()
        {
            mtxtDNI.Clear();
            txtNombre.Clear();
            nudEdad.Value = 0;
            cmbCarrera.SelectedIndex = 0;
            rbManana.Checked = false;
            rbTarde.Checked = false;
            rbNoche.Checked = false;
            txtCorreo.Clear();

            mtxtDNI.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
