using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_colecciones_genericas
{
    public class Alumno : Persona, IContribuyente<int>, IComparable
    {
        public int Referencia { get; set; }
        public string[] ListaAsignaturas { get; set; }
        public string Aula { get; set; }

        public override void MostrarNombre()
        {
            Console.WriteLine("El nombre es " + Nombre + " " + Apellidos);
        }

        public void PagarImpuestos()
        {
            Console.WriteLine("Pagando impuestos");
        }

        public int CompareTo(object obj)
        {
            if (obj is Alumno)
            {
                Alumno alumno = (Alumno)obj;
                return string.Compare(this.Apellidos + ", " + this.Nombre, alumno.Apellidos + ", " + alumno.Nombre);
            }
            else
            {
                return 0;
            }

        }
    }
}
