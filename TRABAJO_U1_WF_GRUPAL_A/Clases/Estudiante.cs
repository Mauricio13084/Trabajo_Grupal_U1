using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO_U1_WF_GRUPAL_A.Clases
{
    public class Estudiante
    {
        // Propiedades
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public string Turno { get; set; }
        public string Correo { get; set; }

        // Constructor vacío
        public Estudiante()
        {
        }

        // Constructor con parámetros (opcional, pero útil)
        public Estudiante(string dni, string nombre, int edad, string carrera, string turno, string correo)
        {
            DNI = dni;
            Nombre = nombre;
            Edad = edad;
            Carrera = carrera;
            Turno = turno;
            Correo = correo;
        }

        // Método ToString para mostrar información (opcional)
        public override string ToString()
        {
            return $"{DNI} - {Nombre} - {Edad} años - {Carrera} - {Turno}";
        }
    }
}
