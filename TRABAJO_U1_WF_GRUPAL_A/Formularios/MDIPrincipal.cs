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
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void AbrirEjercicioHijo(Form formHijo, string nombreEjercicio)
        {
            foreach (Form hijoAbierto in this.MdiChildren)
            {
                hijoAbierto.Close();
            }

            formHijo.MdiParent = this;
            formHijo.Show();

            string horaActual = DateTime.Now.ToString("HH:mm:ss");
            string fechaActual = DateTime.Now.ToShortDateString();

            ListViewItem fila = new ListViewItem(horaActual);
            fila.SubItems.Add(fechaActual);
            fila.SubItems.Add(nombreEjercicio);

            lstHistorial.Items.Add(fila);
        }
        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void ejercicio1ConsumoDeAguaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio1 frm1 = new FrmEjercicio1();
            AbrirEjercicioHijo(frm1, "Ejercicio 01: Validación de Login");
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio2 frm1 = new FrmEjercicio2();
            AbrirEjercicioHijo(frm1, "Ejercicio 02: Calculadora");
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio3 frm1 = new FrmEjercicio3();
            AbrirEjercicioHijo(frm1, "Ejercicio 04: Numero Secreto");
        }

        private void ejercicio4PiedraPapelOTijeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio4 frm1 = new FrmEjercicio4();
            AbrirEjercicioHijo(frm1, "Ejercicio 05: Piedra, Papel Tijera");
        }
    }
}
