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
    public partial class FrmEjercicio18 : Form
    {
        private Producto[] productos = new Producto[100]; 
        private int contadorProductos = 0;

        public FrmEjercicio18()
        {
            InitializeComponent();
        }

        private void FrmEjercicio18_Load_1(object sender, EventArgs e)
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Laptops");
            cmbCategoria.Items.Add("Monitores");
            cmbCategoria.Items.Add("Periféricos");
            cmbCategoria.Items.Add("Computadoras");
            cmbCategoria.Items.Add("Tablets");
            cmbCategoria.Items.Add("Impresoras");
            cmbCategoria.SelectedIndex = 0;

            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add("Codigo", "Código");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Categoria", "Categoría");
            dgvProductos.Columns.Add("StockActual", "Stock");
            dgvProductos.Columns.Add("StockMinimo", "St.Min");
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;

            nudStockActual.Minimum = 0;
            nudStockActual.Maximum = 10000;
            nudStockMinimo.Minimum = 0;
            nudStockMinimo.Maximum = 10000;

            pbPorcentaje.Minimum = 0;
            pbPorcentaje.Maximum = 100;
            pbPorcentaje.Value = 0;

            txtTotal.Text = "0";
            txtMayor.Text = "—";
            txtMenor.Text = "—";

            lstAlertas.ForeColor = Color.Red;


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
   
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("Ingrese el código del producto.",
                        "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del producto.",
                        "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                if (contadorProductos >= productos.Length)
                {
                    MessageBox.Show("Ya no se pueden registrar más productos.",
                        "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < contadorProductos; i++)
                {
                    if (productos[i].Codigo == txtCodigo.Text.Trim())
                    {
                        MessageBox.Show("Ya existe un producto con ese código.",
                            "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigo.Focus();
                        return;
                    }
                }
                Producto nuevo = new Producto(
                    txtCodigo.Text.Trim(),
                    txtNombre.Text.Trim(),
                    cmbCategoria.SelectedItem.ToString(),
                    (int)nudStockActual.Value,
                    (int)nudStockMinimo.Value
                );

                productos[contadorProductos] = nuevo;
                contadorProductos++;

                dgvProductos.Rows.Add(nuevo.Codigo, nuevo.Nombre, nuevo.Categoria,
                                      nuevo.StockActual, nuevo.StockMinimo);

                ActualizarCalculos();
                MessageBox.Show("¡Producto registrado correctamente!",
                    "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void ActualizarCalculos()
        {

            txtTotal.Text = contadorProductos.ToString();

            if (contadorProductos == 0)
            {
                txtMayor.Text = "—";
                txtMenor.Text = "—";
                lstAlertas.Items.Clear();
                pbPorcentaje.Value = 0;
                return;
            }


            int mayorStock = -1;
            int menorStock = int.MaxValue;
            string nombreMayor = "";
            string nombreMenor = "";
            int productosBajoStock = 0;
            int productosSobreStock = 0;

            lstAlertas.Items.Clear();

            for (int i = 0; i < contadorProductos; i++)
            {

                if (productos[i].StockActual > mayorStock)
                {
                    mayorStock = productos[i].StockActual;
                    nombreMayor = productos[i].Codigo;
                }


                if (productos[i].StockActual < menorStock)
                {
                    menorStock = productos[i].StockActual;
                    nombreMenor = productos[i].Codigo;
                }


                if (productos[i].EstaBajoStock())
                {
                    productosBajoStock++;
                    lstAlertas.Items.Add($" {productos[i].Codigo}: {productos[i].StockActual} < {productos[i].StockMinimo}");
                }
                else
                {
                    productosSobreStock++;
                }
            }
            txtMayor.Text = $"{nombreMayor} ({mayorStock})";
            txtMenor.Text = $"{nombreMenor} ({menorStock})";
            int porcentaje = (int)((double)productosSobreStock / contadorProductos * 100);
            pbPorcentaje.Value = porcentaje;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = 0;
            nudStockActual.Value = 0;
            nudStockMinimo.Value = 0;
            txtCodigo.Focus();
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
