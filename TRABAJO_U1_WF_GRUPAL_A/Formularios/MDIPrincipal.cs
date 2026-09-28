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
            FrmEjercicio2 frm = new FrmEjercicio2();
            AbrirEjercicioHijo(frm, "Ejercicio 02");
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio3 frm = new FrmEjercicio3();
            AbrirEjercicioHijo(frm, "Ejercicio 03");
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio4 frm = new FrmEjercicio4();
            AbrirEjercicioHijo(frm, "Ejercicio 04");
        }

        private void ejercicio4PiedraPapelOTijeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio5 frm = new FrmEjercicio5();
            AbrirEjercicioHijo(frm, "Ejercicio 05");
        }

        private void ejercicio5CajeroAutomaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio6 frm = new FrmEjercicio6();
            AbrirEjercicioHijo(frm, "Ejercicio 06");
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio7 frm = new FrmEjercicio7();
            AbrirEjercicioHijo(frm, "Ejercicio 07");
        }

        private void ejercicio7MatrizDeCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio8 frm = new FrmEjercicio8();
            AbrirEjercicioHijo(frm, "Ejercicio 08");
        }

        private void ejericio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio9 frm = new FrmEjercicio9();
            AbrirEjercicioHijo(frm, "Ejercicio 09");
        }

        private void ejericio8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEjercicio10 frm = new FrmEjercicio10();
            AbrirEjercicioHijo(frm, "Ejercicio 10");
        }

        private void ejericio8ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEjercicio11 frm = new FrmEjercicio11();
            AbrirEjercicioHijo(frm, "Ejercicio 11");
        }

        private void ejericio8ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmEjercicio12 frm = new FrmEjercicio12();
            AbrirEjercicioHijo(frm, "Ejercicio 12");
        }

        private void ejericio8ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmEjercicio13 frm = new FrmEjercicio13();
            AbrirEjercicioHijo(frm, "Ejercicio 13");
        }

        private void ejericio8ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmEjercicio14 frm = new FrmEjercicio14();
            AbrirEjercicioHijo(frm, "Ejercicio 14");
        }

        private void ejericio8ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmEjercicio15 frm = new FrmEjercicio15();
            AbrirEjercicioHijo(frm, "Ejercicio 15");
        }

        private void ejericio8ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmEjercicio16 frm = new FrmEjercicio16();
            AbrirEjercicioHijo(frm, "Ejercicio 16");
        }

        private void ejercicio16CalculadoraDeTarifaDeTaxiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio17 frm = new FrmEjercicio17();
            AbrirEjercicioHijo(frm, "Ejercicio 17");
        }

        private void ejercicio17ControlDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio18 frm = new FrmEjercicio18();
            AbrirEjercicioHijo(frm, "Ejercicio 18");
        }

        private void ejercicio18ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio19 frm = new FrmEjercicio19();
            AbrirEjercicioHijo(frm, "Ejercicio 19");
        }

        private void ejercicio19JuegoAltoOSigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio20 frm = new FrmEjercicio20();
            AbrirEjercicioHijo(frm, "Ejercicio 20");
        }
    }
}
