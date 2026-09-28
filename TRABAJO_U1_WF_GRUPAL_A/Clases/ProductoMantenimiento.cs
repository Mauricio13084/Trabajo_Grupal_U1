using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO_U1_WF_GRUPAL_A.Clases
{
    public class ProductoMantenimiento
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double SubTotal { get; set; }
        public string Condicion { get; set; }
        public string Estado { get; set; }

        public ProductoMantenimiento() { }

        public ProductoMantenimiento(int numero, string nombre, string categoria, double precio,
            int cantidad, double subTotal, string condicion, string estado)
        {
            Numero = numero;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Cantidad = cantidad;
            SubTotal = subTotal;
            Condicion = condicion;
            Estado = estado;
        }
    }
}
