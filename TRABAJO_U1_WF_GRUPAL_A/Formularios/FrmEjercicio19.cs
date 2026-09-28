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
    public partial class FrmEjercicio19 : Form
    {
        // Lista donde se guardan los productos
        private List<ProductoMantenimiento> productos = new List<ProductoMantenimiento>();

        private int numeroModificando = 0;

        public FrmEjercicio19()
        {
            InitializeComponent();
        }

        private void FrmEjercicio19_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Disco Duro");
            cmbCategoria.Items.Add("Laptop");
            cmbCategoria.Items.Add("Computadora");
            cmbCategoria.Items.Add("Impresora");
            cmbCategoria.Items.Add("Monitor");
            cmbCategoria.Items.Add("Tablet");
            cmbCategoria.SelectedIndex = 0;

            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add("Numero", "Número");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Categoria", "Categoría");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("SubTotal", "SubTotal");
            dgvProductos.Columns.Add("Condicion", "Condición");
            dgvProductos.Columns.Add("Estado", "Estado");
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;

            txtNumero.ReadOnly = true;
            txtSubtotal.ReadOnly = true;
            txtSubtotal.TextAlign = HorizontalAlignment.Center;
            nudCantidad.Minimum = 0;
            nudCantidad.Maximum = 10000;

            rbBueno.Checked = true;
            rbActivo.Checked = true;

            BloquearCampos(false);

            // Mostrar el primer número
            txtNumero.Text = ObtenerSiguienteNumero().ToString();
        }

        private int ObtenerSiguienteNumero()
        {
            int numero = 1;
            while (true)
            {
                bool existe = false;
                for (int i = 0; i < productos.Count; i++)
                {
                    if (productos[i].Numero == numero)
                    {
                        existe = true;
                        break;
                    }
                }

                if (!existe) return numero;
                numero++;
            }
        }

        private void BloquearCampos(bool bloquear)
        {
            txtNombre.Enabled = !bloquear;
            cmbCategoria.Enabled = !bloquear;
            txtPrecio.Enabled = !bloquear;
            nudCantidad.Enabled = !bloquear;
            rbBueno.Enabled = !bloquear;
            rbRegular.Enabled = !bloquear;
            rbMalo.Enabled = !bloquear;
            rbActivo.Enabled = !bloquear;
            rbInactivo.Enabled = !bloquear;

            btnGrabar.Enabled = !bloquear;
            btnModificar.Enabled = false;
        }

        private void CalcularSubtotal()
        {
            if (double.TryParse(txtPrecio.Text, out double precio) && nudCantidad.Value > 0)
            {
                double subtotal = precio * (int)nudCantidad.Value;
                txtSubtotal.Text = subtotal.ToString("F2");
            }
            else
            {
                txtSubtotal.Text = "0.00";
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar nombre
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del producto.", "Campo vacío",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                // Validar precio
                if (!double.TryParse(txtPrecio.Text, out double precio) || precio <= 0)
                {
                    MessageBox.Show("Ingrese un precio válido mayor a 0.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    return;
                }

                // Validar cantidad
                if (nudCantidad.Value <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad mayor a 0.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudCantidad.Focus();
                    return;
                }

                // Validar condición
                if (!rbBueno.Checked && !rbRegular.Checked && !rbMalo.Checked)
                {
                    MessageBox.Show("Seleccione una condición.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar estado
                if (!rbActivo.Checked && !rbInactivo.Checked)
                {
                    MessageBox.Show("Seleccione un estado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el producto
                int numero = ObtenerSiguienteNumero();
                string condicion = rbBueno.Checked ? "Bueno" : (rbRegular.Checked ? "Regular" : "Malo");
                string estado = rbActivo.Checked ? "Activo" : "Inactivo";

                ProductoMantenimiento nuevo = new ProductoMantenimiento(
                    numero,
                    txtNombre.Text.Trim(),
                    cmbCategoria.SelectedItem.ToString(),
                    precio,
                    (int)nudCantidad.Value,
                    double.Parse(txtSubtotal.Text),
                    condicion,
                    estado
                );

                productos.Add(nuevo);

                MessageBox.Show("Producto grabado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                ListarProductos();
                BloquearCampos(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (numeroModificando == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista para modificar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                !double.TryParse(txtPrecio.Text, out double precio) ||
                nudCantidad.Value <= 0)
            {
                MessageBox.Show("Complete todos los campos correctamente antes de modificar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar y actualizar
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].Numero == numeroModificando)
                {
                    productos[i].Nombre = txtNombre.Text.Trim();
                    productos[i].Categoria = cmbCategoria.SelectedItem.ToString();
                    productos[i].Precio = precio;
                    productos[i].Cantidad = (int)nudCantidad.Value;
                    productos[i].SubTotal = double.Parse(txtSubtotal.Text);
                    productos[i].Condicion = rbBueno.Checked ? "Bueno" : (rbRegular.Checked ? "Regular" : "Malo");
                    productos[i].Estado = rbActivo.Checked ? "Activo" : "Inactivo";
                    break;
                }
            }

            MessageBox.Show("Producto modificado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            ListarProductos();
            BloquearCampos(false);
            numeroModificando = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (numeroModificando == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista para eliminar.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este producto?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                productos.RemoveAll(p => p.Numero == numeroModificando);
                MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                ListarProductos();
                BloquearCampos(false);
                numeroModificando = 0;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            ListarProductos();
        }

        private void ListarProductos()
        {
            dgvProductos.Rows.Clear();
            productos.Sort((a, b) => a.Numero.CompareTo(b.Numero));

            foreach (var p in productos)
            {
                int index = dgvProductos.Rows.Add(p.Numero, p.Nombre, p.Categoria,
                    p.Precio.ToString("F2"), p.Cantidad, p.SubTotal.ToString("F2"),
                    p.Condicion, p.Estado);

                // Colorear según el estado
                if (p.Estado == "Activo")
                    dgvProductos.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    dgvProductos.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Ingrese un nombre para buscar.", "Campo vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvProductos.Rows.Clear();

            foreach (var p in productos)
            {
                if (p.Nombre.ToLower().Contains(busqueda))
                {
                    int index = dgvProductos.Rows.Add(p.Numero, p.Nombre, p.Categoria,
                        p.Precio.ToString("F2"), p.Cantidad, p.SubTotal.ToString("F2"),
                        p.Condicion, p.Estado);

                    if (p.Estado == "Activo")
                        dgvProductos.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                    else
                        dgvProductos.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
                }
            }

            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron productos con ese nombre.",
                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarProductos();
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                numeroModificando = int.Parse(fila.Cells["Numero"].Value.ToString());
                txtNumero.Text = fila.Cells["Numero"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                cmbCategoria.SelectedItem = fila.Cells["Categoria"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                nudCantidad.Value = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                txtSubtotal.Text = fila.Cells["SubTotal"].Value.ToString();

                string condicion = fila.Cells["Condicion"].Value.ToString();
                rbBueno.Checked = condicion == "Bueno";
                rbRegular.Checked = condicion == "Regular";
                rbMalo.Checked = condicion == "Malo";

                string estado = fila.Cells["Estado"].Value.ToString();
                rbActivo.Checked = estado == "Activo";
                rbInactivo.Checked = estado == "Inactivo";

                BloquearCampos(false);
                btnModificar.Enabled = true;
                btnGrabar.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            LimpiarCampos();
            ListarProductos();
            BloquearCampos(false);
            numeroModificando = 0;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = 0;
            txtPrecio.Clear();
            nudCantidad.Value = 0;
            txtSubtotal.Text = "0.00";
            rbBueno.Checked = true;
            rbActivo.Checked = true;

            txtNumero.Text = ObtenerSiguienteNumero().ToString();

            numeroModificando = 0;
            txtNombre.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}