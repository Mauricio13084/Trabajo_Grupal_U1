using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO_U1_WF_GRUPAL_A.Clases
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }

        public Producto()
        {
        }

        public Producto(string codigo, string nombre, string categoria, int stockActual, int stockMinimo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            StockActual = stockActual;
            StockMinimo = stockMinimo;
        }

        // Método debajo del stock mínimo
        public bool EstaBajoStock()
        {
            return StockActual < StockMinimo;
        }

        // Método sobre el stock mínimo
        public bool EstaSobreStock()
        {
            return StockActual >= StockMinimo;
        }
    }
}
